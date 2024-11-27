using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Lenex.Domain.Entities
{
    /// <summary>
    /// This element describes one time standard.
    /// </summary>
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(TypeName = "TIMESTANDARD")]
    public class Timestandard
    {
        /// <summary>
        /// The style contains information like distance, stroke of the record. For each TIMESTANDARD in the same collection, the SWIMSTYLE should be unique.
        /// </summary>
        [XmlElement(ElementName = "SWIMSTYLE")]
        public Swimstyle Swimstyle = new();

        /// <summary>
        /// The time standard or qualification time.
        /// </summary>
        [XmlAttribute(AttributeName = "swimtime")]
        public string? Swimtime;

        /// <summary>
        /// Tag object for markings in user implementation.
        /// </summary>
        [XmlIgnore]
        public object? TagKey;
    }
}
