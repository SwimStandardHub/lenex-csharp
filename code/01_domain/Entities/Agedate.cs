using Lenex.Domain.Enums;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Lenex.Domain.Entities
{
    /// <summary>
    /// The AGEDATE is the date used to calculate the age of an athlete.
    /// </summary>
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public class Agedate
    {
        /// <summary>
        /// The type describes, how the age is calculated.
        /// </summary>
        [XmlAttribute(AttributeName = "type")]
        public EmAgedateType Type = EmAgedateType.YEAR;

        /// <summary>
        /// The date value.
        /// </summary>
        [XmlAttribute(AttributeName = "value")]
        public string? Value;

        /// <summary>
        /// Tag object for markings in user implementation.
        /// </summary>
        /// <exclude/>
        [XmlIgnore]
        public object? TagKey;

    }
}
