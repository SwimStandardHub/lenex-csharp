using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Lenex.Domain.Entities
{
    /// <summary>
    /// This element describes one individual or relay record. It is possible to have no ATHLETE / RELAY objects. In this case the record is a "record standard time".
    /// </summary>
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(TypeName = "RECORD")]
    public class Record
    {
        /// <summary>
        /// The person who holds the record. This is only used for individual records.
        /// </summary>
        [XmlElement(ElementName = "ATHLETE")]
        public Athlete? Athlete = null;

        /// <summary>
        /// This value can be used for additional comments like "Swum in the prelims" or things like that.
        /// </summary>
        [XmlAttribute(AttributeName = "comment")]
        public string? Comment;

        /// <summary>
        /// Information about the meet, where the record was swum.
        /// </summary>
        [XmlElement(ElementName = "MEETINFO")]
        public Meetinfo? Meetinfo = null;

        /// <summary>
        /// The relay team and swimmers, who holds the record. This is only used for relay records.
        /// </summary>
        [XmlElement(ElementName = "RELAY")]
        public Relay? Relay = null;

        /// <summary>
        /// The split times of the record.
        /// </summary>
        [XmlArray(ElementName = "SPLITS")]
        public List<Split>? Splits = null;

        /// <summary>
        /// The swimstyle contains information like distance, stroke of the record.
        /// </summary>
        [XmlElement(ElementName = "SWIMSTYLE")]
        public Swimstyle Swimstyle = new();

        /// <summary>
        /// The final time of the record in the swim time format.
        /// </summary>
        [XmlAttribute(AttributeName = "swimtime")]
        public string? Swimtime;

        /// <summary>
        /// Can be used to add comment about the record, e.g. "Ratification pending by FINA"
        /// </summary>
        [XmlAttribute(AttributeName = "status")]
        public string? Status;

        /// <summary>
        /// Tag object for markings in user implementation.
        /// </summary>
        [XmlIgnore]
        public object? TagKey;
    }
}
