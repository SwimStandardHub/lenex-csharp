using Lenex.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Lenex.Domain.Entities
{
    /// <summary>
    /// This element is used to describe one relay team for a record or for a meet.
    /// </summary>
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(TypeName = "RELAY")]
    public class Relay
    {
        /// <summary>
        /// The maximum age allowed for the oldest swimmer in the team. The value -1 means no upper bound.
        /// </summary>
        [XmlAttribute(AttributeName = "agemax")]
        public int AgeMax = -2;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool AgeMaxSpecified { get => AgeMax > -2; }

        /// <summary>
        /// The minimal age allowed for the youngest swimmer in the team. The value -1 means no lower bound.
        /// </summary>
        [XmlAttribute(AttributeName = "agemin")]
        public int AgeMin = -2;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool AgeMinSpecified { get => AgeMin > -2; }

        /// <summary>
        /// The maximum total age of all swimmers in the relay team. The value -1 means that the total age is unknown.
        /// </summary>
        [XmlAttribute(AttributeName = "agetotalmax")]
        public int AgeTotalMax = -2;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool AgeTotalMaxSpecified { get => AgeTotalMax > -2; }

        /// <summary>
        /// The minimum total age of all swimmers in the relay team. The value -1 means that the total age is unknown.
        /// </summary>
        [XmlAttribute(AttributeName = "agetotalmin")]
        public int AgeTotalMin = -2;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool AgeTotalMinSpecified { get => AgeTotalMin > -2; }

        /// <summary>
        /// The club or team of the relay in the context of a record.
        /// </summary>
        [XmlElement(ElementName = "CLUB")]
        public Club? Club = null;

        /// <summary>
        /// All entries of the relay team.
        /// </summary>
        [XmlArray(ElementName = "ENTRIES")]
        public List<Entry>? Entries;

        /// <summary>
        /// The gender of the relay team.
        /// </summary>
        [XmlAttribute(AttributeName = "gender")]
        public EmSportGender Gender = EmSportGender.F;

        /// <summary>
        /// For relays with handicapped swimmers.
        /// </summary>
        [XmlAttribute(AttributeName = "handicap")]
        public EmRelayHandicap Handicap = EmRelayHandicap.None;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool HandicapSpecified { get => Handicap != EmRelayHandicap.None; }

        /// <summary>
        /// The name of the relay team.
        /// </summary>
        [XmlAttribute(AttributeName = "name")]
        public string? Name;

        /// <summary>
        /// The team number of the relay team. This number is only necessary, if there are different teams of the same club in the same agegroups / events.
        /// </summary>
        [XmlAttribute(AttributeName = "number")]
        public int Number = 0;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool NumberSpecified { get => Number > 0; }

        /// <summary>
        /// The relay swimmers in the context of a relay record.
        /// </summary>
        [XmlArray(ElementName = "RELAYPOSITIONS")]
        public List<Relayposition>? Relaypositions;

        /// <summary>
        /// All results of the relay team.
        /// </summary>
        [XmlArray(ElementName = "RESULTS")]
        public List<Result>? Results;

        /// <summary>
        /// Tag object for markings in user implementation.
        /// </summary>
        [XmlIgnore]
        public object? TagKey;
    }
}
