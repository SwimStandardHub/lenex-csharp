#### [Lenex.Domain](index.md 'index')
### [Lenex.Domain.Entities](Lenex.Domain.Entities.md 'Lenex.Domain.Entities')

## Relayposition Class

This element is used for information about one relay swimmer.

```csharp
public class Relayposition
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Relayposition

| Fields | |
| :--- | :--- |
| [Athlete](Lenex.Domain.Entities.Relayposition.Athlete.md 'Lenex.Domain.Entities.Relayposition.Athlete') | Last name, first name, etc. of the athlete. This element is allowed in the context of a record only and in this case it is required. |
| [AthleteId](Lenex.Domain.Entities.Relayposition.AthleteId.md 'Lenex.Domain.Entities.Relayposition.AthleteId') | A reference to the ATHLETE element of the athlete. This attribute is allowed in the context of a meet sub tree only. |
| [Meetinfo](Lenex.Domain.Entities.Relayposition.Meetinfo.md 'Lenex.Domain.Entities.Relayposition.Meetinfo') | This element contains the information, where the entry time was achieved. This element is only allowed in the context of a relay entry. |
| [Number](Lenex.Domain.Entities.Relayposition.Number.md 'Lenex.Domain.Entities.Relayposition.Number') | The number of the swimmer in the relay. The first swimmer is 1, the second 2 and so on. -1 can be used to add reserve swimmers. |
| [ReactionTime](Lenex.Domain.Entities.Relayposition.ReactionTime.md 'Lenex.Domain.Entities.Relayposition.ReactionTime') | The reaction time at the start of the first swimmer and the relay take over times for other swimmers. |
| [Status](Lenex.Domain.Entities.Relayposition.Status.md 'Lenex.Domain.Entities.Relayposition.Status') | No status attribute means the swimmer finished his part correctly. |
| [TagKey](Lenex.Domain.Entities.Relayposition.TagKey.md 'Lenex.Domain.Entities.Relayposition.TagKey') | Tag object for markings in user implementation. |

| Properties | |
| :--- | :--- |
| [AthleteIdSpecified](Lenex.Domain.Entities.Relayposition.AthleteIdSpecified.md 'Lenex.Domain.Entities.Relayposition.AthleteIdSpecified') | |
| [StatusSpecified](Lenex.Domain.Entities.Relayposition.StatusSpecified.md 'Lenex.Domain.Entities.Relayposition.StatusSpecified') | |
