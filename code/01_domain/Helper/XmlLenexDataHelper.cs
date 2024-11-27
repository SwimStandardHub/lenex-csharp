using System;
using System.Text.RegularExpressions;

namespace Lenex.Domain.Helper
{
    /// <summary>
    /// Class with helper function to parse and format Lenex data.
    /// </summary>
    public static class XmlLenexDataHelper
    {
        #region Public Static Functions

        #region Date and Daytime Formats
        /// <summary>
        /// Get a Lenex Date string
        /// 
        /// Dates are always represented by a string in the form "YYYY-MM-DD". Example: "2004-03-09" means March 9, 2004
        /// </summary>
        public static string GetLenexDate(DateTime date)
        {
            return date.ToString("yyyy-MM-dd");
        }

        /// <summary>
        /// Get a Lenex Daytime string
        /// 
        /// A daytime (hour and minutes) represented by a string in the form "HH:MM". Hours should be from 0 to 24, minutes from 0 to 59.
        /// </summary>
        public static string GetLenexDaytime(DateTime date)
        {
            return date.ToString("HH:mm");
        }

        /// <summary>
        /// Get a DateTime from a Lenex Date
        /// </summary>
        /// <param name="date">Lenex Date</param>
        public static DateTime? GetDateTime(string? date)
        {
            return GetDateTime(date, null);
        }

        /// <summary>
        /// Get a DateTime from a Lenex Date and Daytime
        /// </summary>
        /// <param name="date">Lenex Date</param>
        /// <param name="daytime">Lenex Daytime</param>
        public static DateTime? GetDateTime(string? date, string? daytime)
        {
            if (date == null) return null;

            int _year = 1900, _month = 1, _day = 1, _hour = 0, _minute = 0;

            Regex _dateRegex = new Regex("^(?<Year>[0-9]{4})-(?<Month>[0-9]{2})-(?<Day>[0-9]{2})$");
            HandelDateRegex(date, _dateRegex, ref _year, ref _month, ref _day);

            if (daytime != null)
            {
                Regex _daytimeRegex = new Regex("^(?<Hour>[0-9]{2}):(?<Minutes>[0-9]{2})$");
                HandleDaytimeRegex(daytime, _daytimeRegex, ref _hour, ref _minute);
            }

            return new DateTime(_year, _month, _day, _hour, _minute, 0);
        }
        #endregion

        #region SwimTime

        /// <summary>
        /// Get a SwimTime from a Lenex SwimTime
        /// </summary>
        /// <param name="swimTime">The swim time data type is always a fixed length string of the following form: "HH:MM:SS.ss".
        /// HH: hours from 0 to 99, MM: minutes from 0 to 59, SS: seconds from 0 to 59, ss: Hundreds of a second from 0 to 99. 
        /// Example: "00:14:45.86" means a time of 14:45.86. In addition the string "NT" is allowed if no time is available.</param>
        /// <returns>SwimTime in 100 of a secound.</returns>
        public static int GetSwimTimeValue(string? swimTime)
        {
            if (swimTime == null) return 0;
            int _ret = 0;
            try
            {
                if (swimTime == string.Empty || swimTime == "NT") return 0;

                if (swimTime.Length < 11)
                {
                    swimTime = swimTime.PadLeft(11, '0');
                }

                _ret += Convert.ToInt32(swimTime.Substring(0, 2)) * 360000;
                _ret += Convert.ToInt32(swimTime.Substring(3, 2)) * 6000;
                _ret += Convert.ToInt32(swimTime.Substring(6, 2)) * 100;
                _ret += Convert.ToInt32(swimTime.Substring(9, 2));

                return _ret;
            }
            catch
            {
            }
            return _ret;
        }

        /// <summary>
        /// Get a SwimTime in the Lenex format
        /// </summary>
        /// <param name="swimTime">SwimTime in 100 of a secound.</param>
        /// <param name="NullString">If true returns null, If false returns "NT"</param>
        /// <returns></returns>
        public static string? GetSwimTimeString(int swimTime, bool NullString = true)
        {
            if (swimTime == 0) return NullString ? null : "NT";
            int _hour = swimTime / 360000;
            int _minute = (swimTime - _hour * 360000) / 6000;
            int _secound = (swimTime - _hour * 360000 - _minute * 6000) / 100;
            int _hundreds = swimTime - _hour * 360000 - _minute * 6000 - _secound * 100;

            if (_hour > 99) _hour = 99;

            return $"{_hour.ToString().PadLeft(2, '0')}:{_minute.ToString().PadLeft(2, '0')}:{_secound.ToString().PadLeft(2, '0')}.{_hundreds.ToString().PadLeft(2, '0')}";
        }

        #endregion

        #region ReactionTime
        /// <summary>
        /// Get a ReactionTime in the Lenex format
        /// </summary>
        /// <param name="rtime">The reactiontime in the format from the timing.</param>
        /// <returns></returns>
        public static string? GetReactiontime(string rtime)
        {
            string _ret = string.Empty;
            string _dir = string.Empty;

            rtime = rtime.Trim();
            if (rtime.Length == 0) return null;
            if (rtime == "-.--") return null;
            if (rtime == "0.00" || rtime == "-0.00" || rtime == "+0.00") return "0";
            if (rtime.StartsWith("+")) _dir = "+";
            if (rtime.StartsWith("-")) _dir = "-";
            rtime = rtime.Replace("+", "");
            rtime = rtime.Replace("-", "");
            rtime = rtime.Replace(".", "");
            rtime = rtime.Replace(",", "");

            _ret = Convert.ToInt32(rtime).ToString();
            _ret = (_dir + _ret).Trim();
            return _ret == string.Empty ? null : _ret;
        }
        #endregion

        #endregion

        #region Private Functions
        private static void HandelDateRegex(string? date, Regex _regexObj, ref int _year, ref int _month, ref int _day)
        {
            if (_regexObj.IsMatch(date!))
            {
                foreach (Match m in _regexObj.Matches(date!))
                {
                    for (int i = 1; i < m.Groups.Count; i++)
                    {
                        Group group = m.Groups[i];
                        string name = _regexObj.GroupNameFromNumber(i);
                        switch (name)
                        {
                            case "Year":
                                _year = int.Parse(group.Value);
                                break;
                            case "Month":
                                _month = int.Parse(group.Value);
                                break;
                            case "Day":
                                _day = int.Parse(group.Value);
                                break;
                        }
                    }
                }
            }
        }

        private static void HandleDaytimeRegex(string? date, Regex _regexObj, ref int _hour, ref int _minute)
        {
            if (_regexObj.IsMatch(date!))
            {
                foreach (Match m in _regexObj.Matches(date!))
                {
                    for (int i = 1; i < m.Groups.Count; i++)
                    {
                        Group group = m.Groups[i];
                        string name = _regexObj.GroupNameFromNumber(i);
                        switch (name)
                        {
                            case "Hour":
                                _hour = int.Parse(group.Value);
                                break;
                            case "Minutes":
                                _minute = int.Parse(group.Value);
                                break;
                        }
                    }
                }
            }

        }
        #endregion


    }
}
