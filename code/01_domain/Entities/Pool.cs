using Lenex.Domain.Enums;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Lenex.Domain.Entities
{
    /// <summary>
    /// This element is used to describe the pool where the meet took place.
    /// </summary>
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public class Pool
    {
        /// <summary>
        /// Number of the first lane used in the pool for the meet.
        /// </summary>
        [XmlAttribute(AttributeName = "lanemin")]
        public int LaneMin = -1;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool LaneMinSpecified { get => LaneMin > -1; }

        /// <summary>
        /// Number of the last lane used in the pool for the meet. The number of lanes can be calculated with LANEMAX - LANEMIN + 1.
        /// </summary>
        [XmlAttribute(AttributeName = "lanemax")]
        public int LaneMax = -1;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool LaneMaxSpecified { get => LaneMax > -1; }

        /// <summary>
        /// The type of the pool.
        /// </summary>
        [XmlAttribute(AttributeName = "type")]
        public EmPoolType Type = EmPoolType.None;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool TypeSpecified { get => Type != EmPoolType.None; }

        /// <summary>
        /// The water temperature.
        /// </summary>
        [XmlAttribute(AttributeName = "temperature")]
        public int Temperature = 0;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool TemperatureSpecified { get => Temperature > 0; }

        /// <summary>
        /// Tag object for markings in user implementation.
        /// </summary>
        [XmlIgnore]
        public object? TagKey;
    }
}
