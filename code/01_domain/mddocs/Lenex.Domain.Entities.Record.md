#### [Lenex.Domain](index.md 'index')
### [Lenex.Domain.Entities](Lenex.Domain.Entities.md 'Lenex.Domain.Entities')

## Record Class

This element describes one individual or relay record. It is possible to have no ATHLETE / RELAY objects. In this case the record is a "record standard time".

```csharp
public class Record
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Record

| Fields | |
| :--- | :--- |
| [Athlete](Lenex.Domain.Entities.Record.Athlete.md 'Lenex.Domain.Entities.Record.Athlete') | The person who holds the record. This is only used for individual records. |
| [Comment](Lenex.Domain.Entities.Record.Comment.md 'Lenex.Domain.Entities.Record.Comment') | This value can be used for additional comments like "Swum in the prelims" or things like that. |
| [Meetinfo](Lenex.Domain.Entities.Record.Meetinfo.md 'Lenex.Domain.Entities.Record.Meetinfo') | Information about the meet, where the record was swum. |
| [Relay](Lenex.Domain.Entities.Record.Relay.md 'Lenex.Domain.Entities.Record.Relay') | The relay team and swimmers, who holds the record. This is only used for relay records. |
| [Splits](Lenex.Domain.Entities.Record.Splits.md 'Lenex.Domain.Entities.Record.Splits') | The split times of the record. |
| [Status](Lenex.Domain.Entities.Record.Status.md 'Lenex.Domain.Entities.Record.Status') | Can be used to add comment about the record, e.g. "Ratification pending by FINA" |
| [Swimstyle](Lenex.Domain.Entities.Record.Swimstyle.md 'Lenex.Domain.Entities.Record.Swimstyle') | The swimstyle contains information like distance, stroke of the record. |
| [Swimtime](Lenex.Domain.Entities.Record.Swimtime.md 'Lenex.Domain.Entities.Record.Swimtime') | The final time of the record in the swim time format. |
| [TagKey](Lenex.Domain.Entities.Record.TagKey.md 'Lenex.Domain.Entities.Record.TagKey') | Tag object for markings in user implementation. |
