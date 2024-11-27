using System;

namespace Lenex.Domain.Enums
{
    /// <summary>
    /// </summary>
    [Serializable()]
    public enum EmAthleteStatus
    {
        /// <summary>
        /// </summary>
        None,
        /// <summary>
        /// The athlete swims exhibition in all events.
        /// </summary>
        EXHIBITION,
        /// <summary>
        /// The athlete is a foreigner.
        /// </summary>
        FOREIGNER,
        /// <summary>
        /// </summary>
        ROOKIE
    }
}
