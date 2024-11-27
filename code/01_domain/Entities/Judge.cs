using Lenex.Domain.Enums;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Lenex.Domain.Entities
{
    /// <summary>
    /// This element contains information to attach an official to a session with his role in the session.
    /// </summary>
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(TypeName = "JUDGE")]
    public class Judge
    {
        /// <summary>
        /// The number for judges where there are more than one. This can be used for example for the lane number for timekeepers.
        /// </summary>
        [XmlAttribute(AttributeName = "number")]
        public int Number = 0;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool NumberSpecified { get => Number > 0; }

        /// <summary>
        /// A reference to a OFFICIAL element.
        /// </summary>
        [XmlAttribute(AttributeName = "officialid")]
        public int OfficialId;

        /// <summary>
        /// Additional information for the judge.
        /// </summary>
        [XmlAttribute(AttributeName = "remarks")]
        public string? Remarks;

        /// <summary>
        /// Indicates the role of a judge. The list is built according to the FINA descriptions.
        /// </summary>
        [XmlAttribute(AttributeName = "role")]
        public EmJudgeRole Role = EmJudgeRole.None;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool RoleSpecified { get => Role != EmJudgeRole.None; }

        /// <summary>
        /// Tag object for markings in user implementation.
        /// </summary>
        [XmlIgnore]
        public object? TagKey;
    }
}
