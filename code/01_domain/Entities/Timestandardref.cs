using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Lenex.Domain.Entities
{
    /// <summary>
    /// This element describes a reference from a meet to a time standard list.
    /// </summary>
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(TypeName = "TIMESTANDARDREF")]
    public class Timestandardref
    {
        /// <summary>
        /// The id of the time standard list element.
        /// </summary>
        [XmlAttribute(AttributeName = "timestandardlistid")]
        public int TimestandardlistId;

        /// <summary>
        /// An optional element with a fine for missed time standards.
        /// </summary>
        [XmlElement(ElementName = "FEE")]
        public Fee? Fee = null;

        /// <summary>
        /// An optional string to be used to mark the result, if the time standard was missed. Or to mark a result if a qualification time was fulfilled.
        /// </summary>
        [XmlAttribute(AttributeName = "marker")]
        public string? Marker;

        /// <summary>
        /// Tag object for markings in user implementation.
        /// </summary>
        [XmlIgnore]
        public object? TagKey;
    }
}
