using System;

namespace Lenex.Domain.Enums
{
    /// <summary>
    /// This attribute is used for the result status information. An empty status attribute means a regular result.
    /// </summary>
    [Serializable()]
    public enum EmResultStatus
    {
        /// <summary>
        /// </summary>
        None,
        /// <summary>
        /// exhibition swim
        /// </summary>
        EXH,
        /// <summary>
        /// athlete/relay disqualified
        /// </summary>
        DSQ,
        /// <summary>
        /// athlete/relay did not start (no reason given or to late withdrawl)
        /// </summary>
        DNS,
        /// <summary>
        /// athlete/relay did not finish
        /// </summary>
        DNF,
        /// <summary>
        /// athlete is sick
        /// </summary>
        SICK,
        /// <summary>
        /// athlete/relay was withdrawn (on time)
        /// </summary>
        WDR
    }
}
