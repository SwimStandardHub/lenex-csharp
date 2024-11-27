using System;
using System.Xml.Serialization;

namespace Lenex.Domain.Enums
{
    /// <summary></summary>
    [Serializable()]
    public enum EmRelayHandicap
    {
#pragma warning disable CS1591 // Fehledes XML-Kommentar für öffentlich sichtbaren Typ oder Element
        None,
        [XmlEnum(Name = "14")]
        Em14,
        [XmlEnum(Name = "20")]
        Em20,
        [XmlEnum(Name = "34")]
        Em34,
        [XmlEnum(Name = "49")]
        Em49
#pragma warning restore CS1591 // Fehledes XML-Kommentar für öffentlich sichtbaren Typ oder Element
    }
}
