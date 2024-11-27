using System;

namespace Lenex.Domain.Enums
{
    /// <summary>
    /// Strokes
    /// </summary>
    [Serializable()]
    public enum EmSwimstyleStroke
    {
        /// <summary>
        /// for apnea (fin swimming).
        /// </summary>
        APNEA,
        /// <summary>
        /// for backstroke.
        /// </summary>
        BACK,
        /// <summary>
        /// for bi-fins (fin swimming).
        /// </summary>
        BIFINS,
        /// <summary>
        /// Special mixed relay according to CMAS rules.
        /// </summary>
        MIXEDFINS,
        /// <summary>
        /// for breaststroke.
        /// </summary>
        BREAST,
        /// <summary>
        /// for dynamic (fin swimming). Result is in meter, attribute swimdistance.
        /// </summary>
        DYNAMIC,
        /// <summary>
        /// for dynamic with bi-fins (fin swimming). Result is in meter, attribute swimdistance.
        /// </summary>
        DYNAMIC_BIFINS,
        /// <summary>
        /// for dynamic without fins (fin swimming). Result is in meter, attribute swimdistance.
        /// </summary>
        DYNAMIC_NOFINS,
        /// <summary>
        /// for fly or butterfly.
        /// </summary>
        FLY,
        /// <summary>
        /// for freestyle.
        /// </summary>
        FREE,
        /// <summary>
        /// for immersion (fin swimming).
        /// </summary>
        IMMERSION,
        /// <summary>
        /// for relays where each athletes swims all strokes like in an individual medley event.
        /// </summary>
        IMRELAY,
        /// <summary>
        /// for individual and relay medley. The order of stroke is according to FINA rules: Fly, back, breast, free for individual events. Back, breast, fly, free for relay events.
        /// </summary>
        MEDLEY,
        /// <summary>
        /// for speed apnea (fin swimming).
        /// </summary>
        SPEED_APNEA,
        /// <summary>
        /// for speed endurance (fin swimming).
        /// </summary>
        SPEED_ENDURANCE,
        /// <summary>
        /// for static (fin swimming).
        /// </summary>
        STATIC,
        /// <summary>
        /// for surface (fin swimming).
        /// </summary>
        SURFACE,
        /// <summary>
        /// for all special events. In this case, the name attribute of the event is mandatory.
        /// </summary>
        UNKNOWN
    }
}
