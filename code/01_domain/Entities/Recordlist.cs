using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Lenex.Domain.Entities
{
    /// <summary>
    /// This element describes one single record list.
    /// </summary>
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(TypeName = "RECORDLIST")]
    public class Recordlist
    {
        ///// <summary>
        ///// For agegroup records. Agegroup is "Open", if the element is missing.
        ///// </summary>
        //[XmlElement(ElementName = "AGEGROUP", IsNullable = true)]
        //public Agegroup? Agegroup = null;

        ///// <summary>
        ///// The course for the record list. See section 5.4. for acceptable values.
        ///// </summary>
        //[XmlAttribute(AttributeName = "course")]
        //public EmCours Course = EmCours.LCM;

        ///// <summary>
        ///// The gender for records in this list. Acceptable values are male (M), female (F) and mixed (X). Mixed is only used for relays.
        ///// </summary>
        //[XmlAttribute(AttributeName = "gender")]
        //public EmSportGender Gender = EmSportGender.F;

        ///// <summary>
        ///// The handicap class for the record list. Allowed values are:
        ///// * 1 - 15, 20, 34, 49 standard handicap classes.
        ///// </summary>
        //[XmlAttribute(AttributeName = "handicap")]
        //public EmRelayHandicap? Handicap = null;

        ///// <summary>
        ///// The name of the record list (e.g. "World Records").
        ///// </summary>
        //[XmlAttribute(AttributeName = "name")]
        //public string Name = "";

        ///// <summary>
        ///// For international records, this field is empty. For national or regional records, the field should contain the FINA three letter code of the national federation.
        ///// </summary>
        //[XmlAttribute(AttributeName = "nation")]
        //public string Nation = "";

        ///// <summary>
        ///// This value can be used to define an order for all recordlists within a collection.
        ///// </summary>
        //[XmlAttribute(AttributeName = "order")]
        //public Int32? Order = null;

        ///// <summary>
        ///// The records of this record list.
        ///// </summary>
        //[XmlArray(ElementName = "RECORDS")]
        //public Record[]? Records = new Record[] { };

        ///// <summary>
        ///// For international and national records, this field is empty. For regional records, the field should contain the official code for the region. If region has a value, nation needs to have a value as well.
        ///// </summary>
        //[XmlAttribute(AttributeName = "region")]
        //public string Region = "";

        ///// <summary>
        ///// The date of the last change to the record list.
        ///// </summary>
        //[XmlAttribute(AttributeName = "update")]
        //public string Update = "";

        ///// <summary>
        ///// The record type. The following values are allowed:
        ///// * WR: World records.
        ///// * OR: Olympic records.
        ///// * ER: European records.
        ///// * PAR: Pan American records.
        ///// * AFR: African records.
        ///// * AR: Asian records.
        ///// * OCR: Oceanian records.
        ///// * CWR: Commonwealth records.
        ///// * FINA three letter nation code: The national records of the specific federation.
        ///// This list of types maybe extended by federations. In this case, values should have the nation code and a dot as prefix (e.g.SUI.RZW for records of a region in Switzerland).
        ///// </summary>
        //[XmlAttribute(AttributeName = "type")]
        //public string Type = "";

        /// <summary>
        /// Tag object for markings in user implementation.
        /// </summary>
        [XmlIgnore]
        public object? TagKey;
    }
}
