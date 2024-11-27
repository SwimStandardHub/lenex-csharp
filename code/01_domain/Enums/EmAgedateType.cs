using System;
using System.Xml.Serialization;

namespace Lenex.Domain.Enums
{
    /// <summary>
    /// The type describes, how the age is calculated.
    /// </summary>
    [Serializable()]
    public enum EmAgedateType
    {
        /// <summary>
        /// The age is calculated using the year of the meet and the year of birth only.
        /// </summary>
        [XmlEnum(Name = "YEAR")]
        YEAR,
        /// <summary>
        /// The age is calculated exactly between the date and the birth date.
        /// </summary>
        [XmlEnum(Name = "DATE")]
        DATE,
        /// <summary>
        /// Age calculation according the Portuguese federation.
        /// </summary>
        [XmlEnum(Name = "POR")]
        POR,
        /// <summary>
        /// Calculation according the Quebec federation.
        /// </summary>
        [XmlEnum(Name = "CAN.FNQ")]
        CAN_FNQ,
        /// <summary>
        /// Calculation according the Luxembourg federation.
        /// </summary>
        [XmlEnum(Name = "LUX")]
        LUX
    }
}
