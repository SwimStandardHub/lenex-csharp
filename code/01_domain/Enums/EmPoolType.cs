using System;

namespace Lenex.Domain.Enums
{
    /// <summary>
    /// The type of the pool.
    /// </summary>
    [Serializable()]
    public enum EmPoolType
    {
#pragma warning disable CS1591 // Fehledes XML-Kommentar für öffentlich sichtbaren Typ oder Element
        None,
        INDOOR,
        OUTDOOR,
        LAKE,
        OCEAN
#pragma warning restore CS1591 // Fehledes XML-Kommentar für öffentlich sichtbaren Typ oder Element
    }
}
