using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Lenex.Domain.Entities
{

    /// <summary>
    /// This is the root element of every Lenex file which identifies it as a XML file conforming to the Lenex data format.
    /// </summary>
    [Serializable]
    [XmlRoot("LENEX", Namespace = "", IsNullable = false)]
    public class Lenex
    {
        /// <summary>
        /// This element contains information about the software which created the Lenex file.
        /// </summary>
        [XmlElement(ElementName = "CONSTRUCTOR", IsNullable = false)]
        public Constructor Constructor = new();

        /// <summary>
        /// Contains all the information of meets like athletes, relays, entries and results.
        /// </summary>
        [XmlArray(ElementName = "MEETS")]
        public List<Meet>? Meets = null;

        /// <summary>
        /// Contains different types of records (e.g. World records, Olympic records) including age group records.
        /// </summary>
        [XmlArray(ElementName = "RECORDLISTS")]
        public Recordlist[]? Recordlists = null;

        /// <summary>
        /// Contains different type of time standards and qualification times.
        /// </summary>
        [XmlArray(ElementName = "TIMESTANDARDLISTS")]
        public Timestandardlist[]? Timestandardlists = null;

        /// <summary>
        /// The version number of the Lenex format.
        /// </summary>
        [XmlAttribute(AttributeName = "version")]
        public string Version = "3.0";

        /// <summary>
        /// Tag object for markings in user implementation.
        /// </summary>
        [XmlIgnore]
        public object? TagKey;
    }
}
