using Lenex.Domain.Enums;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Lenex.Domain.Entities
{
    /// <summary>
    /// This element contains all information about an official.
    /// </summary>
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(TypeName = "OFFICIAL")]
    public class Official
    {
        /// <summary>
        /// The contact information of the official.
        /// </summary>
        [XmlElement(ElementName = "CONTACT")]
        public Contact? Contact = null;

        /// <summary>
        /// The first name if the official.
        /// </summary>
        [XmlAttribute(AttributeName = "firstname")]
        public string? Firstname;

        /// <summary>
        /// Gender of the official.
        /// </summary>
        [XmlAttribute(AttributeName = "gender")]
        public EmAthleteGender Gender = EmAthleteGender.None;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool GenderSpecified { get => Gender != EmAthleteGender.None; }

        /// <summary>
        /// The grade of the judge. The value here is specific to national federations and depends on their officials education system.
        /// </summary>
        [XmlAttribute(AttributeName = "grade")]
        public string? Grade;

        /// <summary>
        /// The last name of the official.
        /// </summary>
        [XmlAttribute(AttributeName = "lastname")]
        public string? Lastname;

        /// <summary>
        /// The registration number given by the national federation.
        /// </summary>
        [XmlAttribute(AttributeName = "license")]
        public string? License;

        /// <summary>
        /// An optional name prefix. For example for Peter van den Hoogenband, this could be "van den".
        /// </summary>
        [XmlAttribute(AttributeName = "nameprefix")]
        public string? Nameprefix;

        /// <summary>
        /// See table "Nation Codes" for acceptable values.
        /// </summary>
        [XmlAttribute(AttributeName = "nation")]
        public EmNation Nation = EmNation.None;
        /// <remarks></remarks>
        [XmlIgnore()]
        public bool NationSpecified { get { return Nation != EmNation.None; } }

        /// <summary>
        /// The id attribute should be unique over all officials of a meet. It is required for JUDGE objects in a meet sub tree.
        /// </summary>
        [XmlAttribute(AttributeName = "officialid")]
        public int OfficialId;

        /// <summary>
        /// The passport number of the official.
        /// </summary>
        [XmlAttribute(AttributeName = "passport")]
        public string? Passport;

        /// <summary>
        /// Tag object for markings in user implementation.
        /// </summary>
        [XmlIgnore]
        public object? TagKey;
    }
}
