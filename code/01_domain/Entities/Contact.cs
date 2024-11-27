using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Lenex.Domain.Entities
{
    /// <summary>
    /// This element contains the contact address for a person or organisation.
    /// </summary>
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public class Contact
    {
        /// <summary>
        /// The city of the contact address.
        /// </summary>
        [XmlAttribute(AttributeName = "city")]
        public string? City;

        /// <summary>
        /// See table "Country codes" for acceptable values.
        /// </summary>
        [XmlAttribute(AttributeName = "country")]
        public string? Country;

        /// <summary>
        /// The e-mail address of the contact. The attribute is required in the context of a CONSTRUCTOR element only.
        /// </summary>
        [XmlAttribute(AttributeName = "email")]
        public string? Email;

        /// <summary>
        /// The fax number of the contact.
        /// </summary>
        [XmlAttribute(AttributeName = "fax")]
        public string? Fax;

        /// <summary>
        /// The full URL of the website of the contact person or organisation. The http:// should be included in the string.
        /// </summary>
        [XmlAttribute(AttributeName = "internet")]
        public string? Internet;

        /// <summary>
        /// The full name of the contact person or the name of the organisation.
        /// </summary>
        /// <remarks>
        /// These elements are not used in the context of an OFFICIAL element.
        /// </remarks>
        [XmlAttribute(AttributeName = "name")]
        public string? Name;

        /// <summary>
        /// The mobile phone number of the contact person.
        /// </summary>
        [XmlAttribute(AttributeName = "mobile")]
        public string? Mobile;

        /// <summary>
        /// The phone number of the contact person or the organisation.
        /// </summary>
        [XmlAttribute(AttributeName = "phone")]
        public string? Phone;

        /// <summary>
        /// The state, province or county of the contact address.
        /// </summary>
        [XmlAttribute(AttributeName = "state")]
        public string? State;

        /// <summary>
        /// The first additional line of the address.
        /// </summary>
        [XmlAttribute(AttributeName = "street")]
        public string? Street;

        /// <summary>
        /// The second additional line of the address.
        /// </summary>
        [XmlAttribute(AttributeName = "street2")]
        public string? Street2;

        /// <summary>
        /// The postal code of the address.
        /// </summary>
        [XmlAttribute(AttributeName = "zip")]
        public string? Zip;

        /// <summary>
        /// Tag object for markings in user implementation.
        /// </summary>
        [XmlIgnore]
        public object? TagKey;
    }
}
