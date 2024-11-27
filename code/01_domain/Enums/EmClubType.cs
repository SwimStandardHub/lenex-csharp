using System;

namespace Lenex.Domain.Enums
{
    /// <summary>
    /// The following types of clubs are allowed:
    /// </summary>
    [Serializable()]
    public enum EmClubType
    {
        /// <summary>
        /// This is the default value.
        /// </summary>
        CLUB,
        /// <summary>
        /// The club represents a national team of a federation. In this case, the code, region and nation attribute should be the same.
        /// </summary>
        NOC,
        /// <summary>
        /// The club represents a national team of a federation. In this case, the code, region and nation attribute should be the same.
        /// </summary>
        NATIONALTEAM,
        /// <summary>
        /// The club represents a regional team. In this case, the code and region attribute should be the same.
        /// </summary>
        REGIONALTEAM,
        /// <summary>
        /// To be used for the CLUB entry, that contains data of athletes, where the club is unknown. In this case, the attribute name and the CONTACT element are not required.
        /// </summary>
        UNATTACHED
    }
}
