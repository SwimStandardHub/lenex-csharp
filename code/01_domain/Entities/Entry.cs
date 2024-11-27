using Lenex.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Lenex.Domain.Entities
{
    /// <summary>
    /// This element contains the information for a single entry of an athlete or a relay to a specific round of a meet.
    /// </summary>
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(TypeName = "ENTRY")]
    public class Entry
    {
        /// <summary>
        /// Reference to an age group (AGEGROUP element in the AGEGROUPS collection of the EVENT element).
        /// </summary>
        [XmlAttribute(AttributeName = "agegroupid")]
        public int AgegroupId = 0;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool AgegroupIdSpecified { get => AgegroupId > 0; }

        /// <summary>
        /// This attribute indicates a pool length for the entry time. This is necessary when special seeding rules are used. See section 5.4. for acceptable values.
        /// </summary>
        [XmlAttribute(AttributeName = "entrycourse")]
        public EmCours EntryCourse = EmCours.None;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool EntryCourseSpecified { get => EntryCourse != EmCours.None; }

        /// <summary>
        /// The entry distance in centimeters. Is used for some fin swimming events. For such entries the entrytime should be "NT".
        /// </summary>
        [XmlAttribute(AttributeName = "entrydistance")]
        public int EntryDistance = 0;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool EntryDistanceSpecified { get => EntryDistance > 0; }

        /// <summary>
        /// The entry time in the swim time format.
        /// </summary>
        [XmlAttribute(AttributeName = "entrytime")]
        public string? EntryTime;

        /// <summary>
        /// Reference to the EVENT element using the id attribute.
        /// </summary>
        [XmlAttribute(AttributeName = "eventid")]
        public int EventId;

        /// <summary>
        /// Reference to a heat (HEAT element in HEATS collection of the EVENT element).
        /// </summary>
        [XmlAttribute(AttributeName = "heatid")]
        public int HeatId = 0;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool HeatIdSpecified { get => HeatId > 0; }

        /// <summary>
        /// The heat number of the entry.
        /// </summary>
        [XmlAttribute(AttributeName = "heat")]
        [Obsolete("This property is obsolete and will be removed in a " + "future version. Use the attribut heatid instead.", true)]
        public int Heat = -1;
        /// <remarks></remarks>
        [XmlIgnore]
        [Obsolete("This property is obsolete and will be removed in a future version.")]
        public bool HeatSpecified { get => Heat > -1; }

        /// <summary>
        /// The lane number of the entry.
        /// </summary>
        [XmlAttribute(AttributeName = "lane")]
        public int Lane = -1;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool LaneSpecified { get => Lane > -1 && HeatId > 0; }

        /// <summary>
        /// This element contains the information, about a qualification result for the entry time was achieved.
        /// </summary>
        [XmlElement(ElementName = "MEETINFO")]
        public Meetinfo? Meetinfo;

        /// <summary>
        /// Only for relay entries. This element contains references to the relay swimmers.
        /// </summary>
        [XmlArray(ElementName = "RELAYPOSITIONS")]
        public List<Relayposition>? Relaypositions = null;

        /// <summary>
        /// This attribute is used for the entry status information. An empty status attribute means a regular entry.
        /// </summary>
        [XmlAttribute(AttributeName = "status")]
        public EmEntryStatus Status = EmEntryStatus.Normal;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool StatusSpecified { get => Status != EmEntryStatus.Normal; }

        /// <summary>
        /// Tag object for markings in user implementation.
        /// </summary>
        [XmlIgnore]
        public object? TagKey;
    }
}
