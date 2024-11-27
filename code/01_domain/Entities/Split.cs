using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Lenex.Domain.Entities
{
    /// <summary>
    /// This element contains information about a single split time. In a Lenex file, split times are always saved continuously.
    /// </summary>
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(TypeName = "SPLIT")]
    public class Split
    {
        /// <summary>
        /// The distance where the split time was measured.
        /// </summary>
        [XmlAttribute(AttributeName = "distance")]
        public int Distance;

        /// <summary>
        /// The time of the result in the swim time format.
        /// </summary>
        [XmlAttribute(AttributeName = "swimtime")]
        public string? SwimTime;

        /// <summary>
        /// Tag object for markings in user implementation.
        /// </summary>
        [XmlIgnore]
        public object? TagKey;
    }
}
