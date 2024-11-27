using System;
using System.Xml.Serialization;

namespace Lenex.Domain.Enums
{
    /// <summary>
    /// The handicap class.
    /// </summary>
    [Serializable()]
    public enum EmHandicapClass
    {
        /// <summary>
        /// no handicap
        /// </summary>
        [XmlEnum(Name = "0")]
        S0,
        /// <summary>
        /// Sport Class S1, SB1 or SM1
        /// </summary>
        [XmlEnum(Name = "1")]
        S1,
        /// <summary>
        /// Sport Class S2, SB2 or SM2
        /// </summary>
        [XmlEnum(Name = "2")]
        S2,
        /// <summary>
        /// Sport Class S3, SB3 or SM3
        /// </summary>
        [XmlEnum(Name = "3")]
        S3,
        /// <summary>
        /// Sport Class S4, SB4 or SM4
        /// </summary>
        [XmlEnum(Name = "4")]
        S4,
        /// <summary>
        /// Sport Class S5, SB5 or SM5
        /// </summary>
        [XmlEnum(Name = "5")]
        S5,
        /// <summary>
        /// Sport Class S6, SB6 or SM6
        /// </summary>
        [XmlEnum(Name = "6")]
        S6,
        /// <summary>
        /// Sport Class S7, SB7 or SM7
        /// </summary>
        [XmlEnum(Name = "7")]
        S7,
        /// <summary>
        /// Sport Class S8, SB8 or SM8
        /// </summary>
        [XmlEnum(Name = "8")]
        S8,
        /// <summary>
        /// Sport Class S9, SB9 or SM9
        /// </summary>
        [XmlEnum(Name = "9")]
        S9,
        /// <summary>
        /// Sport Class S10 or SM10
        /// </summary>
        [XmlEnum(Name = "10")]
        S10,
        /// <summary>
        /// Sport Class S11, SB11 or SM11
        /// </summary>
        [XmlEnum(Name = "11")]
        S11,
        /// <summary>
        /// Sport Class S12, SB12 or SM12
        /// </summary>
        [XmlEnum(Name = "12")]
        S12,
        /// <summary>
        /// Sport Class S13, SB13 or SM13
        /// </summary>
        [XmlEnum(Name = "13")]
        S13,
        /// <summary>
        /// Sport Class S14, SB14 or SM14
        /// </summary>
        [XmlEnum(Name = "14")]
        S14,
        /// <summary>
        /// Sport Class S15, SB15 or SM15
        /// </summary>
        [XmlEnum(Name = "15")]
        S15,
        /// <summary>
        /// Sport Class AB
        /// </summary>
        [XmlEnum(Name = "GER.AB")]
        GER_AB,
        /// <summary>
        /// Sport Class GB
        /// </summary>
        [XmlEnum(Name = "GER.GB")]
        GER_GB
    }
}
