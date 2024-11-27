using Lenex.Domain.Enums;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Lenex.Domain.Entities
{
    /// <summary>
    /// The fee is used in MEET and EVENT objects.
    /// </summary>
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(TypeName = "FEE")]
    public class Fee
    {
        /// <summary>
        /// See table "Currency Codes" for acceptable values.
        /// </summary>
        [XmlAttribute(AttributeName = "currency")]
        public EmCurrencyCode Currency = EmCurrencyCode.None;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool CurrencySpecified { get => Currency != EmCurrencyCode.None; }


        /// <summary>
        /// Used in context of FEES in MEET or SESSION objects only.
        /// </summary>
        /// <remarks>
        /// This element is required only in the context of a FEES collection.
        /// </remarks>
        [XmlAttribute(AttributeName = "type")]
        public EmFeeType Type = EmFeeType.None;
        /// <remarks></remarks>
        [XmlIgnore]
        public bool TypeSpecified { get => Type != EmFeeType.None; }

        /// <summary>
        /// The value of the fee in the currency format.
        /// </summary>
        /// <remarks>
        /// An integer number. Currency values are represented in cents, e.g. one dollar in the Lenex currency format is 100.
        /// </remarks>
        [XmlAttribute(AttributeName = "value")]
        public int Value;

        /// <summary>
        /// Tag object for markings in user implementation.
        /// </summary>
        [XmlIgnore]
        public object? TagKey;
    }
}
