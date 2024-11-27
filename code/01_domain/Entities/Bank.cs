using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Lenex.Domain.Entities
{
    /// <summary>
    /// This is used to represent bank payment information for a meet.
    /// </summary>
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    public class Bank
    {
        /// <summary>
        /// The name of the bank account holder.
        /// </summary>
        [XmlAttribute(AttributeName = "accountholder")]
        public string? AccountHolder;

        /// <summary>
        /// The BIC code of the bank.
        /// </summary>
        [XmlAttribute(AttributeName = "bic")]
        public string? Bic;

        /// <summary>
        /// The IBAN number of the bank account. Must be a valid IBAN number.
        /// </summary>
        [XmlAttribute(AttributeName = "iban")]
        public string? Iban;

        /// <summary>
        /// The name of the bank.
        /// </summary>
        [XmlAttribute(AttributeName = "name")]
        public string? Name;

        /// <summary>
        /// Note for the payment as additional information.
        /// </summary>
        [XmlAttribute(AttributeName = "note")]
        public string? Note;
    }
}
