using System;

namespace Lenex.Domain.Enums
{
    /// <summary>
    /// The type of timing.
    /// </summary>
    [Serializable()]
    public enum EmTiming
    {
        /// <summary>
        /// </summary>
        None,
        /// <summary>
        /// A full automatic timing system was used.
        /// </summary>
        AUTOMATIC,
        /// <summary>
        /// Automatic start, manual button for end time.
        /// </summary>
        SEMIAUTOMATIC,
        /// <summary>
        /// Timing was done with three manual times per lane.
        /// </summary>
        MANUAL3,
        /// <summary>
        /// Timing was done with two manual times per lane.
        /// </summary>
        MANUAL2,
        /// <summary>
        /// Timing was done with one manual time per lane.
        /// </summary>
        MANUAL1
    }
}
