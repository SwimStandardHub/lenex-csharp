using Lenex.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Lenex.Domain.Entities
{
    /// <summary>
    /// This element describes one single time standard list.
    /// </summary>
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(TypeName = "TIMESTANDARDLIST")]
    public class Timestandardlist
    {
        /// <summary>
        /// For age group time standards. Agegroup is "Open", if the element is missing.
        /// </summary>
        [XmlElement(ElementName = "AGEGROUP")]
        public Agegroup? Agegroup = null;

        /// <summary>
        /// The course for the timestandard list. See section 5.4. for acceptable values.
        /// </summary>
        [XmlAttribute(AttributeName = "course")]
        public EmCours Course = EmCours.LCM;

        /// <summary>
        /// The gender for time standards in this list. Acceptable values are male (M), female (F) and mixed (X). Mixed is only used for relays.
        /// </summary>
        [XmlAttribute(AttributeName = "gender")]
        public EmSportGender gender = EmSportGender.F;

        /// <summary>
        /// The handicap class for the timestandard list.
        /// </summary>
        [XmlAttribute(AttributeName = "handicap")]
        public EmAgegroupHandicap Handicap = EmAgegroupHandicap.S0;
        /// <remarks></remarks>
        [XmlIgnore()]
        public bool HandicapSpecified { get { return Handicap != EmAgegroupHandicap.S0; } }

        /// <summary>
        /// The name of the time standard list (e.g. "Olympic A Time Standards").
        /// </summary>
        [XmlAttribute(AttributeName = "name")]
        public string? Name;

        /// <summary>
        /// The unique id of the time standard list.
        /// </summary>
        [XmlAttribute(AttributeName = "timestandardlistid")]
        public int TimeStandardListId;

        /// <summary>
        /// The time standards or qualification times of this list.
        /// </summary>
        [XmlArray(ElementName = "TIMESTANDARDS")]
        public List<Timestandard> Timestandards = new();

        /// <summary>
        /// There can be different type of time standards.
        /// </summary>
        [XmlAttribute(AttributeName = "type")]
        public EmTimestandardlistType Type = EmTimestandardlistType.None;
        /// <remarks></remarks>
        [XmlIgnore()]
        public bool TypeSpecified { get { return Type != EmTimestandardlistType.None; } }

        /// <summary>
        /// Tag object for markings in user implementation.
        /// </summary>
        [XmlIgnore]
        public object? TagKey;
    }
}
