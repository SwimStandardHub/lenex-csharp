#### [Lenex.Domain](index.md 'index')
### [Lenex.Domain.Entities](Lenex.Domain.Entities.md 'Lenex.Domain.Entities')

## Event Class

This element contains all information of an event. For events with finals, there has to be an EVENT element for each round.

```csharp
public class Event
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Event

| Fields | |
| :--- | :--- |
| [Agegroups](Lenex.Domain.Entities.Event.Agegroups.md 'Lenex.Domain.Entities.Event.Agegroups') | The AGEGROUPS collection contains the descriptions for the age groups in this event. For Open/Senior events, AGEGROUPS is only needed with one AGEGROUP element as a placeholder for the RANKINGS element (for places in result lists). If round="FHT", then no AGEGROUPS element is allowed. |
| [Daytime](Lenex.Domain.Entities.Event.Daytime.md 'Lenex.Domain.Entities.Event.Daytime') | The daytime of the start of the event. |
| [EventId](Lenex.Domain.Entities.Event.EventId.md 'Lenex.Domain.Entities.Event.EventId') | Every event needs to have an id attribute, so that it can be referenced by ENTRY and RESULT objects. The id attribute has to be unique over all EVENT objects of all sessions of a meet. |
| [Fee](Lenex.Domain.Entities.Event.Fee.md 'Lenex.Domain.Entities.Event.Fee') | The entry fee for this event. If there are global fees per athlete, relay and/or meet, the FEE elements in the MEET element should be used. |
| [Gender](Lenex.Domain.Entities.Event.Gender.md 'Lenex.Domain.Entities.Event.Gender') | The gender of the event. |
| [Heats](Lenex.Domain.Entities.Event.Heats.md 'Lenex.Domain.Entities.Event.Heats') | Collection with all heats in the event. |
| [MaxEntries](Lenex.Domain.Entities.Event.MaxEntries.md 'Lenex.Domain.Entities.Event.MaxEntries') | The maximum number of entries per club in this event. To limit the number of entries per athlete or relay, use the maxentries attribute in the MEET element. |
| [Number](Lenex.Domain.Entities.Event.Number.md 'Lenex.Domain.Entities.Event.Number') | The number of the event. The event numbers should be unique over all events of a meet. The EVENT objects of the different rounds for the same event may have the same event number. |
| [Order](Lenex.Domain.Entities.Event.Order.md 'Lenex.Domain.Entities.Event.Order') | This value can be used to define the order of the events within a session if it is not by the event number and if there are no start times for the events. |
| [PrevEventId](Lenex.Domain.Entities.Event.PrevEventId.md 'Lenex.Domain.Entities.Event.PrevEventId') | This value is a reference to a previous event's id. (e.g. the prelims events for final events). The default value is -1 and means, that there was no previous event. |
| [Round](Lenex.Domain.Entities.Event.Round.md 'Lenex.Domain.Entities.Event.Round') | |
| [Run](Lenex.Domain.Entities.Event.Run.md 'Lenex.Domain.Entities.Event.Run') | Used if there is more than one swim-off necessary. Default value is 1. |
| [Swimstyle](Lenex.Domain.Entities.Event.Swimstyle.md 'Lenex.Domain.Entities.Event.Swimstyle') | The SWIMSTYLE element contains information about distance and stroke of the event. |
| [TagKey](Lenex.Domain.Entities.Event.TagKey.md 'Lenex.Domain.Entities.Event.TagKey') | Tag object for markings in user implementation. |
| [Timestandardrefs](Lenex.Domain.Entities.Event.Timestandardrefs.md 'Lenex.Domain.Entities.Event.Timestandardrefs') | A list of references to TIMESTANDARDREF elements with references to time standard lists to be used for this event. |
| [Timing](Lenex.Domain.Entities.Event.Timing.md 'Lenex.Domain.Entities.Event.Timing') | The type of timing for an event. If missing, the session should be checked and finally the value for the meet should be used. See MEET for acceptable values. |
| [Type](Lenex.Domain.Entities.Event.Type.md 'Lenex.Domain.Entities.Event.Type') | The default value is empty. This applies for regular events that are run according to the FINA rules. |

| Properties | |
| :--- | :--- |
| [GenderSpecified](Lenex.Domain.Entities.Event.GenderSpecified.md 'Lenex.Domain.Entities.Event.GenderSpecified') | |
| [MaxEntriesSpecified](Lenex.Domain.Entities.Event.MaxEntriesSpecified.md 'Lenex.Domain.Entities.Event.MaxEntriesSpecified') | |
| [OrderSpecified](Lenex.Domain.Entities.Event.OrderSpecified.md 'Lenex.Domain.Entities.Event.OrderSpecified') | |
| [PrevEventIdSpecified](Lenex.Domain.Entities.Event.PrevEventIdSpecified.md 'Lenex.Domain.Entities.Event.PrevEventIdSpecified') | |
| [RunSpecified](Lenex.Domain.Entities.Event.RunSpecified.md 'Lenex.Domain.Entities.Event.RunSpecified') | |
| [TimingSpecified](Lenex.Domain.Entities.Event.TimingSpecified.md 'Lenex.Domain.Entities.Event.TimingSpecified') | |
| [TypeSpecified](Lenex.Domain.Entities.Event.TypeSpecified.md 'Lenex.Domain.Entities.Event.TypeSpecified') | |
