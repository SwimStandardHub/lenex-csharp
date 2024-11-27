using Lenex.Domain.Enums;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Lenex.Domain.Entities
{
    /// <summary>
    /// This element contains information about details, how qualification entrytimes are defined.
    /// </summary>
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public class Qualify
    {
        /// <summary>
        /// The way, how times are converted for seeding.
        /// </summary>
        [XmlAttribute(AttributeName = "conversion")]
        public EmQualifyConversion Conversion = EmQualifyConversion.NONE;

        /// <summary>
        /// The first day of the qualification period for entry times.
        /// </summary>
        [XmlAttribute(AttributeName = "from")]
        public string? From;

        /// <summary>
        /// The percentage for conversion PERCENT_LINEAR.
        /// </summary>
        [XmlAttribute(AttributeName = "percent")]
        public int Percent = 0;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool PercentSpecified { get => Percent > 0; }

        /// <summary>
        /// The last day of the qualification period for entry times. If it is missing, then the default is the last day before the first day of the meet.
        /// </summary>
        [XmlAttribute(AttributeName = "until")]
        public string? Until;

        /// <summary>
        /// Tag object for markings in user implementation.
        /// </summary>
        [XmlIgnore]
        public object? TagKey;
    }
}
