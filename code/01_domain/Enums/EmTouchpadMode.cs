using System;

namespace Lenex.Domain.Enums
{
    /// <summary>
    /// Information about timing installation for a meet.
    /// </summary>
    [Serializable()]
    public enum EmTouchpadMode
    {
        /// <summary>
        /// </summary>
        None,
        /// <summary>
        /// Touchpads on one side of the pool.
        /// </summary>
        ONESIDE,
        /// <summary>
        /// Touchpads on both sides of the pool.
        /// </summary>
        BOTHSIDE
    }
}
