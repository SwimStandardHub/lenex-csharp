using Lenex.Domain.Enums;
using Lenex.Domain.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Lenex.Domain.Entities
{
    /// <summary>
    /// This element is used to describe one session of a meet.
    /// </summary>
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(TypeName = "SESSION")]
    public class Session
    {
        /// <summary>
        /// With indicating a pool length per session, the global value of the meet can be overridden, e.g. if the prelim sessions are short course and the finals are long course. See section 5.4. for acceptable values.
        /// </summary>
        [XmlAttribute(AttributeName = "course")]
        public EmCours Course = EmCours.None;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool CourseSpecified { get => Course != EmCours.None; }

        /// <summary>
        /// The date of the session.
        /// </summary>
        [XmlAttribute(AttributeName = "date")]
        public string? Date;

        /// <summary>
        /// The daytime when the session starts.
        /// </summary>
        [XmlAttribute(AttributeName = "daytime")]
        public string? Daytime;

        /// <summary>
        /// This functions set the property Date and Daytime.
        /// </summary>
        /// <param name="date">The DeadLine as DateTime</param>
        public void SetDate(DateTime date)
        {
            Date = XmlLenexDataHelper.GetLenexDate(date);
            Daytime = date.Hour == 0 && date.Minute == 0 ? null : XmlLenexDataHelper.GetLenexDaytime(date);
        }

        /// <summary>
        /// The time when the session ended.
        /// </summary>
        [XmlAttribute(AttributeName = "endtime")]
        public string? Endtime;

        /// <summary>
        /// The events of the session.
        /// </summary>
        [XmlArray(ElementName = "EVENTS")]
        public List<Event> Events = new();

        /// <summary>
        /// Fees used for this session. On this level, different global fees for clubs, athletes and relays are allowed. If there are fees that have to be paid per entry, the FEE element in the EVENT objects should be used.
        /// </summary>
        [XmlArray(ElementName = "FEES")]
        public List<Fee>? Fees;

        /// <summary>
        /// The judges of the session.
        /// </summary>
        [XmlArray(ElementName = "JUDGES")]
        public List<Judge>? Judges;

        /// <summary>
        /// The maximum number of individual entries per athlete in this session.
        /// </summary>
        [XmlAttribute(AttributeName = "maxentriesathlete")]
        public int MaxEntriesAthlete = 0;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool MaxEntriesAthleteSpecified { get => MaxEntriesAthlete > 0; }

        /// <summary>
        /// The maximum number of relay entries per club in this session.
        /// </summary>
        [XmlAttribute(AttributeName = "maxentriesrelay")]
        public int MaxEntriesRelay = 0;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool MaxEntriesRelaySpecified { get => MaxEntriesRelay > 0; }

        /// <summary>
        /// Additional name for the session e.g. "Day 1 - Prelims".
        /// </summary>
        [XmlAttribute(AttributeName = "name")]
        public string? Name;

        /// <summary>
        /// The number of the session. Session numbers in a meet have to be unique.
        /// </summary>
        [XmlAttribute(AttributeName = "number")]
        public int Number = 0;

        /// <summary>
        /// The daytime when the officials meeting starts.
        /// </summary>
        [XmlAttribute(AttributeName = "officialmeeting")]
        public string? OfficialMeeting;

        /// <summary>
        /// The details about the pool, if they are different per session. Otherwise use the element in MEET.
        /// </summary>
        [XmlElement(ElementName = "POOL")]
        public Pool? Pool;

        /// <summary>
        /// Additional remarks given by the referee.
        /// </summary>
        [XmlAttribute(AttributeName = "remarksjudge")]
        public string? RemarksJudge;

        /// <summary>
        /// The daytime when the team leaders meeting starts.
        /// </summary>
        [XmlAttribute(AttributeName = "teamleadermeeting")]
        public string? TeamLeaderMeeting;

        /// <summary>
        /// The type of timing for a session. If missing, the global value for the meet should be used. See MEET for acceptable values.
        /// </summary>
        [XmlAttribute(AttributeName = "timing")]
        public EmTiming Timing = EmTiming.None;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool TimingSpecified { get => Timing != EmTiming.None; }

        /// <summary>
        /// Information about timing installation for a meet.
        /// </summary>
        [XmlAttribute(AttributeName = "touchpadmode")]
        public EmTouchpadMode TouchpadMode = EmTouchpadMode.None;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool TouchpadModeSpecified { get => TouchpadMode != EmTouchpadMode.None; }

        /// <summary>
        /// The daytime when the warmup starts.
        /// </summary>
        [XmlAttribute(AttributeName = "warmupfrom")]
        public string? WarmupFrom;

        /// <summary>
        /// The daytime when the warmup ends.
        /// </summary>
        [XmlAttribute(AttributeName = "warmupuntil")]
        public string? WarmupUntil;

        /// <summary>
        /// Tag object for markings in user implementation.
        /// </summary>
        [XmlIgnore]
        public object? TagKey;
    }
}
