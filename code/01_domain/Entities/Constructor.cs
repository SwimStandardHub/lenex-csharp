using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Lenex.Domain.Entities
{
    /// <summary>
    /// This element contains information about the software, which created the Lenex file and the contact information about the provider of that software.
    /// </summary>
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public class Constructor
    {

        /// <summary>
        /// Contact information of the provider of the software, which created the Lenex file.
        /// </summary>
        [XmlElement(ElementName = "CONTACT", IsNullable = false)]
        public Contact Contact = new();

        /// <summary>
        /// Name of the application that created the Lenex file.
        /// </summary>
        [XmlAttribute(AttributeName = "name")]
        public string Name = "";

        /// <summary>
        /// Name of user, to who the creator application was registered.
        /// </summary>
        [XmlAttribute(AttributeName = "registration")]
        public string? Registration;

        /// <summary>
        /// The version number of the application that created the Lenex file.
        /// </summary>
        [XmlAttribute(AttributeName = "version")]
        public string Version = "";

        /// <summary>
        /// Tag object for markings in user implementation.
        /// </summary>
        [XmlIgnore]
        public object? TagKey;
    }
}
