using System;

namespace Lenex.Domain.Enums
{
    /// <summary>
    /// The type of entries.
    /// </summary>
    [Serializable()]
    public enum EmEntryType
    {
        /// <summary>
        /// </summary>
        None,
        /// <summary>
        /// The meet is open for all clubs/teams.
        /// </summary>
        OPEN,
        /// <summary>
        /// The meet is open to invited clubs/teams only.
        /// </summary>
        INVITATION
    }
}
