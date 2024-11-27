using Lenex.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Lenex.Domain.Entities
{
    /// <summary>
    /// In the meet sub tree, this element contains information about a club, including athletes and relays with their entries and/or results. In the record list sub tree, the element contains information about the club or nation of record holders.
    /// </summary>
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(TypeName = "CLUB")]
    public class Club
    {
        /// <summary>
        /// The athletes of this club.
        /// </summary>
        /// <remarks>
        /// These objects and elements are not used in CLUB objects, which appear in the record list sub tree.
        /// </remarks>
        [XmlArray(ElementName = "ATHLETES")]
        public List<Athlete>? Athletes;

        /// <summary>
        /// The official club code given by the national federation. Only official club codes should be used here!
        /// </summary>
        [XmlAttribute(AttributeName = "code")]
        public string? Code;

        /// <summary>
        /// Contact address for the specific meet.
        /// </summary>
        /// <remarks>
        /// These objects and elements are not used in CLUB objects, which appear in the record list sub tree.
        /// </remarks>
        [XmlElement(ElementName = "CONTACT")]
        public Contact? Contact = null;

        /// <summary>
        /// The full name of the club or the team.
        /// </summary>
        [XmlAttribute(AttributeName = "name")]
        public string? Name;

        /// <summary>
        /// The club name in english.
        /// </summary>
        [XmlAttribute(AttributeName = "name.en")]
        public string? NameEn;

        /// <summary>
        /// See table "Nation Codes" for acceptable values.
        /// </summary>
        [XmlAttribute(AttributeName = "nation")]
        public EmNation Nation = EmNation.None;
        /// <remarks></remarks>
        [XmlIgnore()]
        public bool NationSpecified { get { return Nation != EmNation.None; } }

        /// <summary>
        /// This value can be used to distinguish different teams of the same club in a meet entries or results file.
        /// </summary>
        /// <remarks>
        /// These objects and elements are not used in CLUB objects, which appear in the record list sub tree.
        /// </remarks>
        [XmlAttribute(AttributeName = "number")]
        public int Number = 0;
        /// <remarks></remarks>
        [XmlIgnore()]
        public bool NumberSpecified { get { return Number > 0; } }

        /// <summary>
        /// The officials from this club.
        /// </summary>
        [XmlArray(ElementName = "OFFICIALS")]
        public List<Official>? Officials;

        /// <summary>
        /// The code of the regional or local swimming committee. Only official codes should be used here!
        /// </summary>
        [XmlAttribute(AttributeName = "region")]
        public string? Region;

        /// <summary>
        /// The relay teams of this club.
        /// </summary>
        /// <remarks>
        /// These objects and elements are not used in CLUB objects, which appear in the record list sub tree.
        /// </remarks>
        [XmlArray(ElementName = "RELAYS")]
        public List<Relay>? Relays;

        /// <summary>
        /// A short version of the club name. This string is limited to 20 characters.
        /// </summary>
        [XmlAttribute(AttributeName = "shortname")]
        public string? ShortName;

        /// <summary>
        /// The short version of the club name in english.
        /// </summary>
        [XmlAttribute(AttributeName = "shortname.en")]
        public string? ShortNameEn;

        /// <summary>
        /// The global unique club id given by swimrankings.net.
        /// </summary>
        [XmlAttribute(AttributeName = "swrid")]
        public string? Swrid;

        /// <summary>
        /// Type of the team.
        /// </summary>
        [XmlAttribute(AttributeName = "type")]
        public EmClubType Type = EmClubType.CLUB;
        /// <remarks></remarks>
        [XmlIgnore()]
        public bool TypeSpecified { get { return Type != EmClubType.CLUB; } }

        /// <summary>
        /// Tag object for markings in user implementation.
        /// </summary>
        [XmlIgnore]
        public object? TagKey;
    }
}
