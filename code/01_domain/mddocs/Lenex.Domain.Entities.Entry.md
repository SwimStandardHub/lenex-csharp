#### [Lenex.Domain](index.md 'index')
### [Lenex.Domain.Entities](Lenex.Domain.Entities.md 'Lenex.Domain.Entities')

## Entry Class

This element contains the information for a single entry of an athlete or a relay to a specific round of a meet.

```csharp
public class Entry
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Entry

| Fields | |
| :--- | :--- |
| [AgegroupId](Lenex.Domain.Entities.Entry.AgegroupId.md 'Lenex.Domain.Entities.Entry.AgegroupId') | Reference to an age group (AGEGROUP element in the AGEGROUPS collection of the EVENT element). |
| [EntryCourse](Lenex.Domain.Entities.Entry.EntryCourse.md 'Lenex.Domain.Entities.Entry.EntryCourse') | This attribute indicates a pool length for the entry time. This is necessary when special seeding rules are used. See section 5.4. for acceptable values. |
| [EntryDistance](Lenex.Domain.Entities.Entry.EntryDistance.md 'Lenex.Domain.Entities.Entry.EntryDistance') | The entry distance in centimeters. Is used for some fin swimming events. For such entries the entrytime should be "NT". |
| [EntryTime](Lenex.Domain.Entities.Entry.EntryTime.md 'Lenex.Domain.Entities.Entry.EntryTime') | The entry time in the swim time format. |
| [EventId](Lenex.Domain.Entities.Entry.EventId.md 'Lenex.Domain.Entities.Entry.EventId') | Reference to the EVENT element using the id attribute. |
| [Heat](Lenex.Domain.Entities.Entry.Heat.md 'Lenex.Domain.Entities.Entry.Heat') | The heat number of the entry. |
| [HeatId](Lenex.Domain.Entities.Entry.HeatId.md 'Lenex.Domain.Entities.Entry.HeatId') | Reference to a heat (HEAT element in HEATS collection of the EVENT element). |
| [Lane](Lenex.Domain.Entities.Entry.Lane.md 'Lenex.Domain.Entities.Entry.Lane') | The lane number of the entry. |
| [Meetinfo](Lenex.Domain.Entities.Entry.Meetinfo.md 'Lenex.Domain.Entities.Entry.Meetinfo') | This element contains the information, about a qualification result for the entry time was achieved. |
| [Relaypositions](Lenex.Domain.Entities.Entry.Relaypositions.md 'Lenex.Domain.Entities.Entry.Relaypositions') | Only for relay entries. This element contains references to the relay swimmers. |
| [Status](Lenex.Domain.Entities.Entry.Status.md 'Lenex.Domain.Entities.Entry.Status') | This attribute is used for the entry status information. An empty status attribute means a regular entry. |
