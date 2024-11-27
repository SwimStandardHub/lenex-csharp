using System;

namespace Lenex.Domain.Enums
{
    /// <summary>
    /// Information for relay events about how the age is calculated.
    /// </summary>
    [Serializable()]
    public enum EmAgegroupCalculate
    {
        /// <summary>
        /// </summary>
        None,
        /// <summary>
        /// This is the default value. The age of each relay swimmer has to be in the given range.
        /// </summary>
        SINGLE,
        /// <summary>
        /// The total age of all swimmers has to be in the given range.
        /// </summary>
        TOTAL
    }
}
