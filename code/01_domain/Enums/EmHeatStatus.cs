namespace Lenex.Domain.Enums
{
    /// <summary>
    /// The status of a heat.
    /// </summary>
    public enum EmHeatStatus
    {
        /// <summary>
        /// </summary>
        None,
        /// <summary>
        /// The heat is seeded.
        /// </summary>
        SEEDED,
        /// <summary>
        /// Results are available but not official.
        /// </summary>
        INOFFICIAL,
        /// <summary>
        /// Results of the heat are official.
        /// </summary>
        OFFICIAL
    }
}
