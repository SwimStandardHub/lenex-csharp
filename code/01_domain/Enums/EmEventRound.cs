using System;
using System.Xml.Serialization;

namespace Lenex.Domain.Enums
{
    /// <summary></summary>
    [Serializable()]
    public enum EmEventRound
    {
        /// <summary>
        /// This is the default value. Used for an event with timed finals.
        /// </summary>
        [XmlEnum(Name = "TIM")]
        TIM,
        /// <summary>
        /// Fastest heats of an event with timed finals. Events with this value for round should always refer to the corresponding timed final event, which should be of the same distance, stroke and age groups. Events with round set to FHT only make sence for the schedule and ENTRY objects, but never to be used for RESULT's. 
        /// </summary>
        [XmlEnum(Name = "FHT")]
        FHT,
        /// <summary>
        /// This is used for finals including A, B, C, … finals.
        /// </summary>
        [XmlEnum(Name = "FIN")]
        FIN,
        /// <summary>
        /// for semi finals.
        /// </summary>
        [XmlEnum(Name = "SEM")]
        SEM,
        /// <summary>
        /// for quarterfinals.
        /// </summary>
        [XmlEnum(Name = "QUA")]
        QUA,
        /// <summary>
        /// for prelims.
        /// </summary>
        [XmlEnum(Name = "PRE")]
        PRE,
        /// <summary>
        /// Swim-Off after prelims.
        /// </summary>
        [XmlEnum(Name = "SOP")]
        SOP,
        /// <summary>
        /// Swim-Off after semi-finals.
        /// </summary>
        [XmlEnum(Name = "SOS")]
        SOS,
        /// <summary>
        /// Swim-Off after quarterfinals.
        /// </summary>
        [XmlEnum(Name = "SOQ")]
        SOQ,
        /// <summary>
        /// Germany: Reswim, Nachschwimmen
        /// </summary>
        [XmlEnum(Name = "GER.RES")]
        GERRES,
        /// <summary>
        /// a time trail (like a timed final without heats and time trail starts)
        /// </summary>
        [XmlEnum(Name = "TIMETRIAL")]
        TIMETRIAL
    }
}
