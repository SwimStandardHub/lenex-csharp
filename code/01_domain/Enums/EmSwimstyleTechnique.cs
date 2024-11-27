using System;

namespace Lenex.Domain.Enums
{
    /// <summary></summary>
    [Serializable()]
    public enum EmSwimstyleTechnique
    {
        /// <summary>
        /// </summary>
        None,
        /// <summary>
        /// for swimming under water.
        /// </summary>
        DIVE,
        /// <summary>
        /// for gliding only.
        /// </summary>
        GLIDE,
        /// <summary>
        /// for kick only (Swimming with legs, no arms used).
        /// </summary>
        KICK,
        /// <summary>
        /// for pull only (Swimming with arms, no legs used).
        /// </summary>
        PULL,
        /// <summary>
        /// for start only.
        /// </summary>
        START,
        /// <summary>
        /// for turn only.
        /// </summary>
        TURN
    }
}
