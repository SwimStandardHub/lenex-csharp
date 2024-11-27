using Lenex.Domain.Enums;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Lenex.Domain.Entities
{
    /// <summary>
    /// This element is used to describe one swim style.
    /// </summary>
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public class Swimstyle
    {
        /// <summary>
        /// A code (max. 6 characters) of the swim style if the stroke is unknown.
        /// </summary>
        [XmlAttribute(AttributeName = "code")]
        public string? Code;

        /// <summary>
        /// The distance for the event. For relay events it is the distance for one single athlete.
        /// </summary>
        [XmlAttribute(AttributeName = "distance")]
        public int Distance = 50;

        /// <summary>
        /// The full descriptive name of the swim style if the stroke is unknown (e.g. "5 x 75m Breast with one Arm only").
        /// </summary>
        [XmlAttribute(AttributeName = "name")]
        public string? Name;

        /// <summary>
        /// The number of swimmers per entry / result. Value 1 means, that it is an individual event. All other values mean, that it is a relay event.
        /// </summary>
        [XmlAttribute(AttributeName = "relaycount")]
        public int Relaycount = 1;

        /// <summary>
        /// The Swimstyle.
        /// </summary>
        [XmlAttribute(AttributeName = "stroke")]
        public EmSwimstyleStroke Stroke = EmSwimstyleStroke.UNKNOWN;

        /// <summary>
        /// The id attribute is important for SWIMSTYLE objects, where the stroke attribute is "UNKNOWN". In this case, the id should be a unique value to help to identify the swim style.
        /// </summary>
        [XmlAttribute(AttributeName = "swimstyleid")]
        public int SwimstyleId = 0;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool SwimstyleIdSpecified { get => SwimstyleId > 0; }

        /// <summary>
        /// The technique of the style. If this attribute is missing or empty, it means normal swimming. All other values are mainly used for technical events in meets for kids.
        /// </summary>
        [XmlAttribute(AttributeName = "technique")]
        public EmSwimstyleTechnique Technique = EmSwimstyleTechnique.None;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool TechniqueSpecified { get => Technique != EmSwimstyleTechnique.None; }

        /// <summary>
        /// Tag object for markings in user implementation.
        /// </summary>
        [XmlIgnore]
        public object? TagKey;
    }
}
