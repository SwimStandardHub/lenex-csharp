using Lenex.Domain.Enums;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Lenex.Domain.Entities
{
    /// <summary>
    /// This element is used in entries and records for general information about a meet.
    /// </summary>
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public class Meetinfo
    {
        /// <summary>
        /// Contains a code for the organisation, who approved the qualification time, e.g. FINA, LEN or a IOC nation code. If this field is empty, the qualification time was not approved.
        /// </summary>
        /// <remarks>
        /// These elements are used in the context of a ENTRY / RELAYPOSITION element only.
        /// </remarks>
        [XmlAttribute(AttributeName = "approved")]
        public string? Approved;

        /// <summary>
        /// The city name where the meet took place.
        /// </summary>
        /// <remarks>
        /// These elements are required only in the context of a RECORD element.
        /// </remarks>
        [XmlAttribute(AttributeName = "city")]
        public string? City;

        /// <summary>
        /// This attribute indicates the pool length, where the qualification time was achieved. See section 5.4. for acceptable values.
        /// </summary>
        /// <remarks>
        /// These elements are used in the context of a ENTRY / RELAYPOSITION element only.
        /// </remarks>
        [XmlAttribute(AttributeName = "course")]
        public EmCours Course = EmCours.None;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool CourseSpecified { get => Course != EmCours.None; }

        /// <summary>
        /// The date of the swim of the record or qualification time achievement.
        /// </summary>
        /// <remarks>
        /// These elements are required only in the context of a RECORD element.
        /// </remarks>
        [XmlAttribute(AttributeName = "date")]
        public string? Date;

        /// <summary>
        /// The day time of the swim.
        /// </summary>
        [XmlAttribute(AttributeName = "daytime")]
        public string? Daytime;

        /// <summary>
        /// The meet name.
        /// </summary>
        [XmlAttribute(AttributeName = "name")]
        public string? Name;

        /// <summary>
        /// The nation of the city for the meet.
        /// </summary>
        /// <remarks>
        /// These elements are required only in the context of a RECORD element.
        /// </remarks>
        [XmlAttribute(AttributeName = "nation")]
        public EmNation Nation = EmNation.None;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool NationSpecified { get => Nation != EmNation.None; }

        /// <summary>
        /// The details about the pool.
        /// </summary>
        [XmlElement(ElementName = "POOL")]
        public Pool? Pool = null;

        /// <summary>
        /// The qualification time, since this can be different to the entry
        /// </summary>
        /// <remarks>
        /// These elements are used in the context of a ENTRY / RELAYPOSITION element only.
        /// </remarks>
        [XmlAttribute(AttributeName = "qualificationtime")]
        public string? Qualificationtime;

        /// <summary>
        /// The state of the city for the meet.
        /// </summary>
        [XmlAttribute(AttributeName = "state")]
        public string? State;

        /// <summary>
        /// Tag object for markings in user implementation.
        /// </summary>
        [XmlIgnore]
        public object? TagKey;
    }
}
