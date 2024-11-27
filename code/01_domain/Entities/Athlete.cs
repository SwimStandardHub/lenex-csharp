using Lenex.Domain.Enums;
using Lenex.Domain.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Lenex.Domain.Entities
{
    /// <summary>
    /// This contains all information of a athlete including all entries and results in the context of a meet sub tree.
    /// </summary>
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(TypeName = "ATHLETE")]
    public class Athlete
    {
        /// <summary>
        /// The id attribute should be unique over all athletes of a meet. It is required for ATHLETE objects in a meet sub tree.
        /// </summary>
        [XmlAttribute(AttributeName = "athleteid")]
        public int AthleteId;

        /// <summary>
        /// The date of birth for the athlete. If only the year of birth is known, the date should be set to January 1st of that year.
        /// </summary>
        [XmlAttribute(AttributeName = "birthdate")]
        public string? Birthdate;

        /// <summary>
        /// This functions set the property Birthdate.
        /// </summary>
        /// <param name="birthdate">The Birthdate as DateTime</param>
        public void SetBirthdate(DateTime birthdate)
        {
            Birthdate = XmlLenexDataHelper.GetLenexDate(birthdate);
        }

        /// <summary>
        /// This function get the Birthdate as DateTime.
        /// </summary>
        public DateTime? GetBirthdate()
        {
            return XmlLenexDataHelper.GetDateTime(Birthdate);
        }

        /// <summary>
        /// The club or team for the athlete, when he swam the record.
        /// </summary>
        /// <remarks>
        /// These elements/objects are allowed in a record list sub tree only.
        /// </remarks>
        [XmlElement(ElementName = "CLUB")]
        public Club? Club = null;

        /// <summary>
        /// All entries of the athlete.
        /// </summary>
        [XmlArray(ElementName = "ENTRIES")]
        public List<Entry>? Entries = null;

        /// <summary>
        /// The first name of the athlete.
        /// </summary>
        [XmlAttribute(AttributeName = "firstname")]
        public string? Firstname;

        /// <summary>
        /// The first name in english.
        /// </summary>
        [XmlAttribute(AttributeName = "firstname.en")]
        public string? FirstnameEn;

        /// <summary>
        /// Gender of the athlete.
        /// </summary>
        [XmlAttribute(AttributeName = "gender")]
        public EmAthleteGender Gender = EmAthleteGender.F;

        /// <summary>
        /// Information about the handicap classes of a swimmer.
        /// </summary>
        [XmlElement(ElementName = "HANDICAP")]
        public Handicap? Handicap = null;

        /// <summary>
        /// The last name of the athlete.
        /// </summary>
        [XmlAttribute(AttributeName = "lastname")]
        public string? Lastname;

        /// <summary>
        /// The last name in english.
        /// </summary>
        [XmlAttribute(AttributeName = "lastname.en")]
        public string? LastnameEn;

        /// <summary>
        /// The level of the athlete (used with levels in AGEGROUP).
        /// </summary>
        [XmlAttribute(AttributeName = "level")]
        public string? Level;

        /// <summary>
        /// The registration number given by the national federation. This number should be looked at together with the nation of the club the athlete is listed in the Lenex file.
        /// </summary>
        [XmlAttribute(AttributeName = "license")]
        public string? License;

        /// <summary>
        /// The registration number given by World Para Swimming, also known as SDMS ID.
        /// </summary>
        [XmlAttribute(AttributeName = "license_ipc")]
        public string? LicenseIpc;

        /// <summary>
        /// The registration number given by Deutscher Behinderten Sportverband.
        /// </summary>
        [XmlAttribute(AttributeName = "license_dbs")]
        public string? LicenseDbs;

        /// <summary>
        /// The registration number given by Deutscher Behinderten Sportverband.
        /// </summary>
        [XmlAttribute(AttributeName = "license_dsv")]
        public string? LicenseDsv;

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
        /// The passport number of the athlete.
        /// </summary>
        [XmlAttribute(AttributeName = "passport")]
        public string? Passport;

        /// <summary>
        /// All results of the athlete.
        /// </summary>
        [XmlArray(ElementName = "RESULTS")]
        public List<Result>? Results;

        /// <summary>
        /// </summary>
        [XmlAttribute(AttributeName = "status")]
        public EmAthleteStatus Status = EmAthleteStatus.None;
        /// <remarks></remarks>
        [XmlIgnore()]
        public bool StatusSpecified { get { return Status != EmAthleteStatus.None; } }

        /// <summary>
        /// The global unique athlete id given by swimrankings.net.
        /// </summary>
        [XmlAttribute(AttributeName = "swrid")]
        public string? Swrid;

        /// <summary>
        /// Tag object for markings in user implementation.
        /// </summary>
        [XmlIgnore]
        public object? TagKey;
    }
}
