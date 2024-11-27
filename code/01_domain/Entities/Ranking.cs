using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Lenex.Domain.Entities
{
    /// <summary>
    /// This element describes one entry in the rankings of one agegroup. It contains the place and a reference to a result (individual or relay).
    /// </summary>
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(TypeName = "RANKING")]
    public class Ranking
    {
        /// <summary>
        /// This value can be used to define the order of the results. If it is missing, the value for place is used to sort the elements in a collection.
        /// </summary>
        [XmlAttribute(AttributeName = "order")]
        public int Order = 0;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool OrderSpecified { get => Order > 0; }

        /// <summary>
        /// The final position in the result list for the current event/round.
        /// </summary>
        [XmlAttribute(AttributeName = "place")]
        public int Place;

        /// <summary>
        /// A reference to the RESULT element.
        /// </summary>
        [XmlAttribute(AttributeName = "resultid")]
        public int ResultId;

        /// <summary>
        /// Tag object for markings in user implementation.
        /// </summary>
        [XmlIgnore]
        public object? TagKey;
    }
}
