using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Lenex.Domain.Enums
{
    /// <summary>
    /// 
    /// </summary>
    public enum EmStartmethod
    {
        /// <summary>
        /// one start allowed (default value)
        /// </summary>
        [XmlEnum(Name = "1")]
        OneStartRule,
        /// <summary>
        /// two starts allowed
        /// </summary>
        [XmlEnum(Name = "2")]
        TwoStartRule
    }
}
