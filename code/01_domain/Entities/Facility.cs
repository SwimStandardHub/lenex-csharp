using Lenex.Domain.Enums;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Lenex.Domain.Entities
{
    /// <summary>
    /// This element contains name and full address of meets facility.
    /// </summary>
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public class Facility
    {
        /// <summary>
        /// The city of the facility.
        /// </summary>
        [XmlAttribute(AttributeName = "city")]
        public string? City;

        /// <summary>
        /// See table "Country codes" for acceptable values.
        /// </summary>
        [XmlAttribute(AttributeName = "nation")]
        public EmCountryCodes Nation = EmCountryCodes.DE;

        /// <summary>
        /// The name of the facility (e.g. "Aquatic Center").
        /// </summary>
        [XmlAttribute(AttributeName = "name")]
        public string? Name;

        /// <summary>
        /// The state, province or county of the address.
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
