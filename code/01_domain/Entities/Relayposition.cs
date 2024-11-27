using Lenex.Domain.Enums;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Lenex.Domain.Entities
{
    /// <summary>
    /// This element is used for information about one relay swimmer.
    /// </summary>
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(TypeName = "RELAYPOSITION")]
    public class Relayposition
    {
        /// <summary>
        /// Last name, first name, etc. of the athlete. This element is allowed in the context of a record only and in this case it is required.
        /// </summary>
        [XmlElement(ElementName = "ATHLETE")]
        public Athlete? Athlete = null;

        /// <summary>
        /// A reference to the ATHLETE element of the athlete. This attribute is allowed in the context of a meet sub tree only.
        /// </summary>
        [XmlAttribute(AttributeName = "athleteid")]
        public int AthleteId = 0;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool AthleteIdSpecified { get => AthleteId > 0; }

        /// <summary>
        /// This element contains the information, where the entry time was achieved. This element is only allowed in the context of a relay entry.
        /// </summary>
        [XmlElement(ElementName = "MEETINFO")]
        public Meetinfo? Meetinfo;

        /// <summary>
        /// The number of the swimmer in the relay. The first swimmer is 1, the second 2 and so on. -1 can be used to add reserve swimmers.
        /// </summary>
        [XmlAttribute(AttributeName = "number")]
        public int Number;

        /// <summary>
        /// The reaction time at the start of the first swimmer and the relay take over times for other swimmers.
        /// </summary>
        [XmlAttribute(AttributeName = "reactiontime")]
        public string? ReactionTime;

        /// <summary>
        /// No status attribute means the swimmer finished his part correctly.
        /// </summary>
        [XmlAttribute(AttributeName = "status")]
        public EmRelaypositionStatus Status = EmRelaypositionStatus.None;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool StatusSpecified { get => Status != EmRelaypositionStatus.None; }

        /// <summary>
        /// Tag object for markings in user implementation.
        /// </summary>
        [XmlIgnore]
        public object? TagKey;
    }
}
