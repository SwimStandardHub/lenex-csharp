using Lenex.Domain.Enums;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Lenex.Domain.Entities
{
    /// <summary>
    /// The heat is used to define more details in the start list (e.g. schedule).
    /// </summary>
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(TypeName = "HEAT")]
    public class Heat
    {
        /// <summary>
        /// Reference to an age group (AGEGROUP element in the AGEGROUPS collection of the EVENT element).
        /// </summary>
        [XmlAttribute(AttributeName = "agegroupid")]
        public int AgegroupId = 0;
        /// <remarks></remarks>
        [XmlIgnore()]
        public bool AgegroupIdSpecified { get { return AgegroupId > 0; } }

        /// <summary>
        /// The daytime of the start of the event.
        /// </summary>
        [XmlAttribute(AttributeName = "daytime")]
        public string? Daytime;

        /// <summary>
        /// This value is used to identify A, B, ... finals. Allowed are characters A, B, C and D.
        /// </summary>
        [XmlAttribute(AttributeName = "final")]
        public string? Final;

        /// <summary>
        /// The id attribute should be unique over all heats of a meet. It is required when you have ENTRY / RESULT objects that reference to a heat.
        /// </summary>
        [XmlAttribute(AttributeName = "heatid")]
        public int HeatId;

        /// <summary>
        /// The number of the heat. The heat numbers have to be unique within one event, also in a case when you have A finals in different agegroups.
        /// </summary>
        [XmlAttribute(AttributeName = "number")]
        public int Number;

        /// <summary>
        /// This value can be used to define the order of the heats within an event if it is not by the heat number and if there are no start times for the heats.
        /// </summary>
        [XmlAttribute(AttributeName = "order")]
        public int Order = 0;
        /// <remarks></remarks>
        [XmlIgnore()]
        public bool OrderSpecified { get { return Order > 0; } }

        /// <summary>
        /// The status of the heat.
        /// </summary>
        [XmlAttribute(AttributeName = "status")]
        public EmHeatStatus Status = EmHeatStatus.None;
        /// <remarks></remarks>
        [XmlIgnore()]
        public bool StatusSpecified { get { return Status != EmHeatStatus.None; } }

        /// <summary>
        /// Tag object for markings in user implementation.
        /// </summary>
        [XmlIgnore]
        public object? TagKey;
    }
}
