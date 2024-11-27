using System;

namespace Lenex.Domain.Enums
{
    /// <summary>
    /// There can be different type of time standards. Default value is MAXIMUM.
    /// </summary>
    [Serializable()]
    public enum EmTimestandardlistType
    {
        /// <summary>
        /// </summary>
        None,
        /// <summary>
        /// The time standards describe a set of default times, that may be used in a team competition, where a result for an event of a team is missing or invalid and therefore is replaced by this default time.
        /// </summary>
        DEFAULT,
        /// <summary>
        /// The time standards describe a maximal time for a meet. Swimmers can only compete, when they are faster than the time standards.
        /// </summary>
        MAXIMUM,
        /// <summary>
        /// The time standards describe a minimal time for a meet. Swimmers can only compete, when they are slower than the time standards.
        /// </summary>
        MINIMUM
    }
}
