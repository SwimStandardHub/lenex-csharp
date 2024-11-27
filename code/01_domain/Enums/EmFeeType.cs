using System;
using System.Xml.Serialization;

namespace Lenex.Domain.Enums
{
    /// <summary></summary>
    [Serializable()]
    public enum EmFeeType
    {
        /// <summary>
        /// </summary>
        None,
        /// <summary>
        /// global fee to be paid per club for the meet
        /// </summary>
        CLUB,
        /// <summary>
        /// global fee to be paid per athlete
        /// </summary>
        ATHLETE,
        /// <summary>
        /// global fee to be paid per relay team
        /// </summary>
        RELAY,
        /// <summary>
        /// global fee to be paid per team (e.g. Swiss Team Championship)
        /// </summary>
        TEAM,
        /// <summary>
        /// fee per entry for individual late entries. This value is used in the context of MEET.FEES only.
        /// </summary>
        [XmlEnum(Name = "LATEENTRY.INDIVIDUAL")]
        LATEENTRY_INDIVIDUAL,
        /// <summary>
        /// fee per entry for relay late entries. This value is used in the context of MEET.FEES only.
        /// </summary>
        [XmlEnum(Name = "LATEENTRY.RELAY")]
        LATEENTRY_RELAY
    }
}
