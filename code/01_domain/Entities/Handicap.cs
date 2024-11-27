using Lenex.Domain.Enums;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Lenex.Domain.Entities
{
    /// <summary>
    /// Information about the handicap classes of a swimmer.
    /// </summary>
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public class Handicap
    {
        /// <summary>
        /// The handicap class for breaststroke.
        /// </summary>
        [XmlAttribute(AttributeName = "breast")]
        public EmHandicapClass Breast = EmHandicapClass.S0;

        /// <summary>
        /// Additional information about handicap.
        /// </summary>
        [XmlAttribute(AttributeName = "exception")]
        public string? Exception;

        /// <summary>
        /// The handicap class for freestyle, backstroke and fly.
        /// </summary>
        [XmlAttribute(AttributeName = "free")]
        public EmHandicapClass Free = EmHandicapClass.S0;

        /// <summary>
        /// The handicap class for individual medley.
        /// </summary>
        [XmlAttribute(AttributeName = "medley")]
        public EmHandicapClass Medley = EmHandicapClass.S0;

        /// <summary>
        /// Tag object for markings in user implementation.
        /// </summary>
        [XmlIgnore]
        public object? TagKey;
    }
}
