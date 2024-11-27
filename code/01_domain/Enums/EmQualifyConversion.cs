using System;

namespace Lenex.Domain.Enums
{
    /// <summary>
    /// The way, how times are converted for seeding.
    /// </summary>
    [Serializable()]
    public enum EmQualifyConversion
    {
        /// <summary>
        /// This is the default value. No conversion will be done.
        /// </summary>
        NONE,
        /// <summary>
        /// Entry times, flaged with a course other than the event course will be converted by calculating the FINA points and from there calculating back to a swim time.
        /// </summary>
        FINA_POINTS,
        /// <summary>
        /// Here the conversion will be done by adding / subtracting a certain percantage to the original entry time.
        /// </summary>
        PERCENT_LINEAR,
        /// <summary>
        /// In this case, entries that are flaged with the event course will be seeded first, all other entries will be seeded after these.
        /// </summary>
        NON_CONFORMING_LAST
    }
}
