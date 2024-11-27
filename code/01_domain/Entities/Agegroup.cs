using Lenex.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Lenex.Domain.Entities
{
    /// <summary>
    /// This element contains information about an age range. It is used in events and record lists.
    /// </summary>
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(TypeName = "AGEGROUP")]
    public class Agegroup
    {
        /// <summary>
        /// Only for events, every AGEGROUP element needs an id, because the objects can be referenced from ENTRY objects. The id has to be unique within an AGEGROUPS collection.
        /// </summary>
        [XmlAttribute(AttributeName = "agegroupid")]
        public int AgegroupId;

        /// <summary>
        /// The upper bound of the age range. -1 means no upper bound.
        /// </summary>
        [XmlAttribute(AttributeName = "agemax")]
        public int Agemax = -1;

        /// <summary>
        /// The lower bound of the age range. -1 means no lower bound.
        /// </summary>
        [XmlAttribute(AttributeName = "agemin")]
        public int Agemin = -1;

        /// <summary>
        /// In mixed events, the gender can be specifiedin the AGEGROUP objects. Values can be male (M), female (F) or mixed (X). Mixed is only used for relays. This can be useful to define events with gender set to all (A), but the ranking is separated. This attribute is not allowed in the context of a RECORDLIST or TIMESTANDARDLIST element.
        /// </summary>
        [XmlAttribute(AttributeName = "gender")]
        public EmSportGender Gender = EmSportGender.None;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool GenderSpecified { get => Gender != EmSportGender.None; }

        /// <summary>
        /// Information for relay events about how the age is calculated.
        /// </summary>
        [XmlAttribute(AttributeName = "calculate")]
        public EmAgegroupCalculate Calculate = EmAgegroupCalculate.None;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool CalculateSpecified { get => Calculate != EmAgegroupCalculate.None; }

        /// <summary>
        /// The handicap class for the agegroup. This is used to group results by disability categories.
        /// </summary>
        [XmlAttribute(AttributeName = "handicap")]
        public EmAgegroupHandicap Handicap = EmAgegroupHandicap.S0;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool HandicapSpecified { get => Handicap != EmAgegroupHandicap.S0; }

        /// <summary>
        /// The maximum level (A-Z) of the agegroup. If the value is missing, this means no upper bound.
        /// </summary>
        [XmlAttribute(AttributeName = "levelmax")]
        public string? LevelMax;

        /// <summary>
        /// The minimum level (A-Z) of the agegroup. If the value is missing, this means no lower bound.
        /// </summary>
        [XmlAttribute(AttributeName = "levelmin")]
        public string? LevelMin;

        /// <summary>
        /// Comma separated list of codes of allowed athlete levels.
        /// </summary>
        [XmlAttribute(AttributeName = "levels")]
        public string? Levels;

        /// <summary>
        /// The name of the age group (e.g. "Juniors").
        /// </summary>
        [XmlAttribute(AttributeName = "name")]
        public string? Name;

        /// <summary>
        /// A collection with references to results ranked in this agegroup.
        /// </summary>
        [XmlArray(ElementName = "RANKINGS")]
        public List<Ranking>? Rankings = null;

        /// <summary>
        /// Tag object for markings in user implementation.
        /// </summary>
        [XmlIgnore]
        public object? TagKey;
    }
}
