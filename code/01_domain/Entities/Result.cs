using Lenex.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Lenex.Domain.Entities
{
    /// <summary>
    /// This element is used to describe one result of a swimmer or relay team.
    /// </summary>
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(TypeName = "RESULT")]
    public class Result
    {
        /// <summary>
        /// Additional comment e.g. for new records or reasons for disqualifications.
        /// </summary>
        [XmlAttribute(AttributeName = "comment")]
        public string? Comment;

        /// <summary>
        /// Reference to the EVENT element using the id attribute.
        /// </summary>
        [XmlAttribute(AttributeName = "eventid")]
        public int EventId;

        /// <summary>
        /// Reference to a heat (HEAT element in HEATS collection of the EVENT element).
        /// </summary>
        [XmlAttribute(AttributeName = "heatid")]
        public int HeatId = 0;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool HeatIdSpecified { get => HeatId > 0; }

        /// <summary>
        /// The heat number of the entry.
        /// </summary>
        [XmlAttribute(AttributeName = "heat")]
        public int Heat = -1;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool HeatSpecified { get => Heat > -1; }

        /// <summary>
        /// The lane number of the entry.
        /// </summary>
        [XmlAttribute(AttributeName = "lane")]
        public int Lane = 0;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool LaneSpecified { get => Lane > 0; }

        /// <summary>
        /// The number of points for the result according to the scoring table used in a meet.
        /// </summary>
        [XmlAttribute(AttributeName = "points")]
        public int Points = 0;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool PointsSpecified { get => Points > 0; }

        /// <summary>
        /// The reaction time at the start. For relay events it is the reaction time of the first swimmer.
        /// </summary>
        [XmlAttribute(AttributeName = "reactiontime")]
        public string? ReactionTime;

        /// <summary>
        /// The information about relay swimmers in this result. Only allowed for relay RESULT objects.
        /// </summary>
        [XmlArray(ElementName = "RELAYPOSITIONS")]
        public List<Relayposition>? Relaypositions;

        /// <summary>
        /// Each result needs a unique id which should be unique over a meet.
        /// </summary>
        [XmlAttribute(AttributeName = "resultid")]
        public int ResultId;

        /// <summary>
        /// This attribute is used for the result status information. An empty status attribute means a regular result.
        /// </summary>
        [XmlAttribute(AttributeName = "status")]
        public EmResultStatus Status = EmResultStatus.None;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool StatusSpecified { get => Status != EmResultStatus.None; }

        /// <summary>
        /// The split times for the result. In a Lenex file, split times are always saved continuously.
        /// </summary>
        [XmlArray(ElementName = "SPLITS")]
        public List<Split>? Splits;

        /// <summary>
        /// The result distance in centimeters. Is used for some fin swimming events. For such results the swimtime should be "NT".
        /// </summary>
        [XmlAttribute(AttributeName = "swimdistance")]
        public int SwimDistance = 0;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool SwimDistanceSpecified { get => SwimDistance > 0; }

        /// <summary>
        /// The final time of the result in the swim time format.
        /// </summary>
        [XmlAttribute(AttributeName = "swimtime")]
        public string? SwimTime;

        /// <summary>
        /// Tag object for markings in user implementation.
        /// </summary>
        [XmlIgnore]
        public object? TagKey;
    }
}
