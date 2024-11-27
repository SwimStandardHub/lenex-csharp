using System;

namespace Lenex.Domain.Enums
{
    /// <summary>
    /// Indicates the role of a judge. The list is built according to the FINA descriptions.
    /// </summary>
    [Serializable()]

    public enum EmJudgeRole
    {
        /// <summary>
        /// </summary>
        None,
        /// <summary>
        /// other or unknown. This is the default value.
        /// </summary>
        OTH,
        /// <summary>
        /// The meet director.
        /// </summary>
        MDR,
        /// <summary>
        /// The technical delegate.
        /// </summary>
        TDG,
        /// <summary>
        /// The referees.
        /// </summary>
        REF,
        /// <summary>
        /// The starters.
        /// </summary>
        STA,
        /// <summary>
        /// The announcers or speakers.
        /// </summary>
        ANN,
        /// <summary>
        /// The judge of strokes.
        /// </summary>
        JOS,
        /// <summary>
        /// The chief timekeeper
        /// </summary>
        CTIK,
        /// <summary>
        /// The timekeepers
        /// </summary>
        TIK,
        /// <summary>
        /// The chief finish judge
        /// </summary>
        CFIN,
        /// <summary>
        /// The finish judges
        /// </summary>
        FIN,
        /// <summary>
        /// The chief inspectors of turns.
        /// </summary>
        CIOT,
        /// <summary>
        /// The inspectors of turns.
        /// </summary>
        IOT,
        /// <summary>
        /// The false start rope personnel.
        /// </summary>
        FSR,
        /// <summary>
        /// The clerks of course.
        /// </summary>
        COC,
        /// <summary>
        /// The chief recorders.
        /// </summary>
        CREC,
        /// <summary>
        /// The recorders.
        /// </summary>
        REC,
        /// <summary>
        /// Control room supervisor
        /// </summary>
        CRS,
        /// <summary>
        /// Control room (computerroom)
        /// </summary>
        CR,
        /// <summary>
        /// Medical service
        /// </summary>
        MED
    }
}
