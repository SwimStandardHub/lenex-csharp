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
    /// This element contains all information of one meet, including events, athletes, relays, entries and results.
    /// </summary>
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(TypeName = "MEET")]
    public class Meet
    {
        /// <summary>
        /// The name of the meet. Normally the name should not contain a full date (maybe the year only) and/or a city or pool name.
        /// </summary>
        [XmlAttribute(AttributeName = "name")]
        public string Name = "";

        /// <summary>
        /// Meet name in english.
        /// </summary>
        [XmlAttribute(AttributeName = "name.en")]
        public string? NameEn;

        /// <summary>
        /// Height above sea level of the meet city.
        /// </summary>
        [XmlAttribute(AttributeName = "altitude")]
        public int Altitude = 0;
        /// <remarks></remarks>
        [XmlIgnore()]
        public bool AltitudeSpecified { get { return Altitude > 0; } }

        /// <summary>
        /// The name of the city where the meet was run. Should be the same as FACILITY.city
        /// </summary>
        [XmlAttribute(AttributeName = "city")]
        public string? City;

        /// <summary>
        /// Name of meet city in english.
        /// </summary>
        [XmlAttribute(AttributeName = "city.en")]
        public string? CityEn;

        /// <summary>
        /// The size of the pool. If the attribute is not available, all SESSION objects need to have a course attribute.
        /// </summary>
        [XmlAttribute(AttributeName = "course")]
        public EmCours Course = EmCours.None;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool CourseSpecified { get => Course != EmCours.None; }

        /// <summary>
        /// The global unique meet id given by swimrankings.net.
        /// </summary>
        [XmlAttribute(AttributeName = "swrid")]
        public string? SwrId;

        /// <summary>
        /// The type of timing for a meet.
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
        /// The date for withdrawals from the entry list.
        /// </summary>
        [XmlAttribute(AttributeName = "withdrawuntil")]
        public string? WithDrawUntil;

        /// <summary>
        /// This functions set the property WithDrawUntil.
        /// </summary>
        /// <param name="withDrawUntil">The WithDrawUntil as DateTime</param>
        public void WithDrawUntilDate(DateTime withDrawUntil)
        {
            WithDrawUntil = XmlLenexDataHelper.GetLenexDate(withDrawUntil);
        }

        /// <summary>
        /// This functions set the property DeadLine and DeadLineTime.
        /// </summary>
        /// <param name="deadLine">The DeadLine as DateTime</param>
        public void SetDeadLine(DateTime deadLine)
        {
            DeadLine = XmlLenexDataHelper.GetLenexDate(deadLine);
            DeadLineTime = deadLine.Hour == 0 && deadLine.Minute == 0 ? null : XmlLenexDataHelper.GetLenexDaytime(deadLine);
        }

        /// <summary>
        /// This function get the Deadline as DateTime.
        /// </summary>
        public DateTime? GetDeadLine()
        {
            return XmlLenexDataHelper.GetDateTime(DeadLine, DeadLineTime);
        }

        /// <summary>
        /// The date for the entry deadline.
        /// </summary>
        [XmlAttribute(AttributeName = "deadline")]
        public string? DeadLine;

        /// <summary>
        /// The exact time for the entry deadline.
        /// </summary>
        [XmlAttribute(AttributeName = "deadlinetime")]
        public string? DeadLineTime;

        /// <summary>
        /// This functions set the property EntryStartDate.
        /// </summary>
        /// <param name="deadLine">The EntryStartDate as DateTime</param>
        public void SetEntryStartDate(DateTime deadLine)
        {
            EntryStartDate = XmlLenexDataHelper.GetLenexDate(deadLine);
        }

        /// <summary>
        /// The date from when (online) entries are open/available.
        /// </summary>
        [XmlAttribute(AttributeName = "entrystartdate")]
        public string? EntryStartDate;

        /// <summary>
        /// The type of (online) entries
        /// </summary>
        [XmlAttribute(AttributeName = "entrytype")]
        public EmEntryType EntryType = EmEntryType.None;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool EntryTypeSpecified { get => EntryType != EmEntryType.None; }

        /// <summary>
        /// The executing federation or club of the meet (e.g. the German Swimming Federation, if the European Champ was held in Berlin).
        /// </summary>
        [XmlAttribute(AttributeName = "hostclub")]
        public string? HostClub;

        /// <summary>
        /// A website url, that directs to the executing club for the meet
        /// </summary>
        [XmlAttribute(AttributeName = "hostclub.url")]
        public string? HostClubUrl;

        /// <summary>
        /// The maximum number of individual entries per athlete in this meet.
        /// </summary>
        [XmlAttribute(AttributeName = "maxentriesathlete")]
        public int MaxEntriesAthlete = 0;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool MaxEntriesAthleteSpecified { get => MaxEntriesAthlete > 0; }

        /// <summary>
        /// The maximum number of relay entries per club in this meet.
        /// </summary>
        [XmlAttribute(AttributeName = "maxentriesrelay")]
        public int MaxEntriesRelay = 0;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool MaxEntriesRelaySpecified { get => MaxEntriesRelay > 0; }

        /// <summary>
        /// The three letter code of the nation of the meet city. This should be the same as FACILITY.nation
        /// </summary>
        [XmlAttribute(AttributeName = "nation")]
        public EmNation Nation = EmNation.GER;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool NationSpecified { get => Nation != EmNation.None; }

        /// <summary>
        /// The sanction number for the meet by the federation.
        /// </summary>
        [XmlAttribute(AttributeName = "number")]
        public string? Number;

        /// <summary>
        /// The organisation which promotes the meet (e.g. FINA for the World Championships).
        /// </summary>
        [XmlAttribute(AttributeName = "organizer")]
        public string? Organizer;

        /// <summary>
        /// A website url, that directs to the organizer of the meet.
        /// </summary>
        [XmlAttribute(AttributeName = "organizer.url")]
        public string? OrganizerUrl;

        /// <summary>
        /// The number of reserve swimmers in finals and semifinals.
        /// </summary>
        [XmlAttribute(AttributeName = "reservecount")]
        public int ReserveCount = 0;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool ReserveCountSpecified { get => ReserveCount > 0; }

        /// <summary>
        /// A website url, that directs to the results page. This should be a deep (direct) link to the result lists and not the general website of a meet.
        /// </summary>
        [XmlAttribute(AttributeName = "result.url")]
        public string? ResultUrl;

        /// <summary>
        /// 1 start rule or 2 start rule.
        /// </summary>
        [XmlAttribute(AttributeName = "startmethod")]
        public EmStartmethod Startmethode = 0;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool StartmethodeSpecified { get => Startmethode != EmStartmethod.OneStartRule; }


        /// <summary>
        /// The date to be used to calculate the age of athletes. The default value is the date of the first session and type by year of birth only.
        /// </summary>
        [XmlElement(ElementName = "AGEDATE")]
        public Agedate? Agedate;

        /// <summary>
        /// Information for a bank account for payment of entry fees.
        /// </summary>
        [XmlElement(ElementName = "BANK")]
        public Bank? Bank = null;

        /// <summary>
        /// The contact address of the meet organizer.
        /// </summary>
        [XmlElement(ElementName = "CONTACT")]
        public Contact? Contact = null;

        /// <summary>
        /// The full address of the meets facility.
        /// </summary>
        [XmlElement(ElementName = "FACILITY")]
        public Facility? Facility;

        /// <summary>
        /// Description of the point table used for scoring.
        /// </summary>
        [XmlElement(ElementName = "POINTTABLE")]
        public Pointtable? Pointtable = null;

        /// <summary>
        /// Details about the pool where the meet took place.
        /// </summary>
        [XmlElement(ElementName = "POOL")]
        public Pool? Pool = null;

        /// <summary>
        /// Details about how qualification times for entries are defined.
        /// </summary>
        [XmlElement(ElementName = "QUALIFY")]
        public Qualify? Qualify = null;

        /// <summary>
        /// Description of all events grouped by session.
        /// </summary>
        [XmlArray(ElementName = "SESSIONS")]
        public List<Session> Sessions = new();

        /// <summary>
        /// Fees used for this meet. On this level, different global fees for clubs, athletes and relays are allowed. If there are fees that have to be paid per entry, the FEE element in the EVENT objects should be used.
        /// </summary>
        [XmlArray(ElementName = "FEES")]
        public List<Fee>? Fees;

        /// <summary>
        /// Collection of clubs of the meet.
        /// </summary>
        [XmlArray(ElementName = "CLUBS")]
        public List<Club>? Clubs = null;

        /// <summary>
        /// Tag object for markings in user implementation.
        /// </summary>
        [XmlIgnore]
        public object? TagKey;
    }
}
