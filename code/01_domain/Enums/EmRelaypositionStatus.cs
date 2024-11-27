using System;

namespace Lenex.Domain.Enums
{
    /// <summary></summary>
    [Serializable()]
    public enum EmRelaypositionStatus
    {
        /// <summary>
        /// </summary>
        None,
        /// <summary>
        /// relay athlete was disqualified
        /// </summary>
        DSQ,
        /// <summary>
        /// relay athlete did not finish
        /// </summary>
        DNF
    }
}
