using System;

namespace Lenex.Domain.Enums
{
    /// <summary>
    /// This attribute is used for the entry status information. An empty status attribute means a regular entry.
    /// </summary>
    [Serializable()]
    public enum EmEntryStatus
    {
        /// <summary>
        /// </summary>
        Normal,
        /// <summary>
        /// exhibition swim
        /// </summary>
        EXH,
        /// <summary>
        /// rejected entry
        /// </summary>
        RJC,
        /// <summary>
        /// athlete is sick
        /// </summary>
        SICK,
        /// <summary>
        /// athlete/relay was withdrawn
        /// </summary>
        WDR
    }
}
