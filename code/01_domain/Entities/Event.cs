using Lenex.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Lenex.Domain.Entities
{
    /// <summary>
    /// This element contains all information of an event. For events with finals, there has to be an EVENT element for each round.
    /// </summary>
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(TypeName = "EVENT")]
    public class Event
    {
        /// <summary>
        /// The AGEGROUPS collection contains the descriptions for the age groups in this event. For Open/Senior events, AGEGROUPS is only needed with one AGEGROUP element as a placeholder for the RANKINGS element (for places in result lists). If round="FHT", then no AGEGROUPS element is allowed.
        /// </summary>
        [XmlArray(ElementName = "AGEGROUPS")]
        public List<Agegroup>? Agegroups = null;

        /// <summary>
        /// The daytime of the start of the event.
        /// </summary>
        [XmlAttribute(AttributeName = "daytime")]
        public string? Daytime;

        /// <summary>
        /// Every event needs to have an id attribute, so that it can be referenced by ENTRY and RESULT objects. The id attribute has to be unique over all EVENT objects of all sessions of a meet.
        /// </summary>
        [XmlAttribute(AttributeName = "eventid")]
        public int EventId;

        /// <summary>
        /// The entry fee for this event. If there are global fees per athlete, relay and/or meet, the FEE elements in the MEET element should be used.
        /// </summary>
        [XmlElement(ElementName = "FEE")]
        public Fee? Fee = null;

        /// <summary>
        /// The gender of the event.
        /// </summary>
        [XmlAttribute(AttributeName = "gender")]
        public EmSportGender Gender = EmSportGender.None;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool GenderSpecified { get => Gender != EmSportGender.None; }

        /// <summary>
        /// Collection with all heats in the event.
        /// </summary>
        [XmlArray(ElementName = "HEATS")]
        public List<Heat>? Heats = null;

        /// <summary>
        /// The maximum number of entries per club in this event. To limit the number of entries per athlete or relay, use the maxentries attribute in the MEET element.
        /// </summary>
        [XmlAttribute(AttributeName = "maxentries")]
        public int MaxEntries = 0;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool MaxEntriesSpecified { get => MaxEntries > 0; }

        /// <summary>
        /// The number of the event. The event numbers should be unique over all events of a meet. The EVENT objects of the different rounds for the same event may have the same event number.
        /// </summary>
        [XmlAttribute(AttributeName = "number")]
        public int Number;

        /// <summary>
        /// This value can be used to define the order of the events within a session if it is not by the event number and if there are no start times for the events.
        /// </summary>
        [XmlAttribute(AttributeName = "order")]
        public int Order = 0;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool OrderSpecified { get => Order > 0; }

        /// <summary>
        /// This value is a reference to a previous event's id. (e.g. the prelims events for final events). The default value is -1 and means, that there was no previous event.
        /// </summary>
        [XmlAttribute(AttributeName = "preveventid")]
        public int PrevEventId = 0;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool PrevEventIdSpecified { get => PrevEventId > 0; }

        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute(AttributeName = "round")]
        public EmEventRound Round = EmEventRound.TIM;

        /// <summary>
        /// Used if there is more than one swim-off necessary. Default value is 1.
        /// </summary>
        [XmlAttribute(AttributeName = "run")]
        public int Run = 0;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool RunSpecified { get => Run > 0; }

        /// <summary>
        /// The SWIMSTYLE element contains information about distance and stroke of the event.
        /// </summary>
        [XmlElement(ElementName = "SWIMSTYLE")]
        public Swimstyle Swimstyle = new();

        /// <summary>
        /// A list of references to TIMESTANDARDREF elements with references to time standard lists to be used for this event.
        /// </summary>
        [XmlArray(ElementName = "TIMESTANDARDREFS")]
        public List<Timestandardref>? Timestandardrefs = null;

        /// <summary>
        /// The type of timing for an event. If missing, the session should be checked and finally the value for the meet should be used. See MEET for acceptable values.
        /// </summary>
        [XmlAttribute(AttributeName = "timing")]
        public EmTiming Timing = EmTiming.None;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool TimingSpecified { get => Timing != EmTiming.None; }

        /// <summary>
        /// The default value is empty. This applies for regular events that are run according to the FINA rules.
        /// </summary>
        [XmlAttribute(AttributeName = "type")]
        public EmEventType Type = EmEventType.None;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool TypeSpecified { get => Type != EmEventType.None; }

        /// <summary>
        /// Tag object for markings in user implementation.
        /// </summary>
        [XmlIgnore]
        public object? TagKey;
    }
}
