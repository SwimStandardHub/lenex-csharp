#### [Lenex.Domain](index.md 'index')
### [Lenex.Domain.Entities](Lenex.Domain.Entities.md 'Lenex.Domain.Entities')

## Result Class

This element is used to describe one result of a swimmer or relay team.

```csharp
public class Result
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Result

| Fields | |
| :--- | :--- |
| [Comment](Lenex.Domain.Entities.Result.Comment.md 'Lenex.Domain.Entities.Result.Comment') | Additional comment e.g. for new records or reasons for disqualifications. |
| [EventId](Lenex.Domain.Entities.Result.EventId.md 'Lenex.Domain.Entities.Result.EventId') | Reference to the EVENT element using the id attribute. |
| [Heat](Lenex.Domain.Entities.Result.Heat.md 'Lenex.Domain.Entities.Result.Heat') | The heat number of the entry. |
| [HeatId](Lenex.Domain.Entities.Result.HeatId.md 'Lenex.Domain.Entities.Result.HeatId') | Reference to a heat (HEAT element in HEATS collection of the EVENT element). |
| [Lane](Lenex.Domain.Entities.Result.Lane.md 'Lenex.Domain.Entities.Result.Lane') | The lane number of the entry. |
| [Points](Lenex.Domain.Entities.Result.Points.md 'Lenex.Domain.Entities.Result.Points') | The number of points for the result according to the scoring table used in a meet. |
| [ReactionTime](Lenex.Domain.Entities.Result.ReactionTime.md 'Lenex.Domain.Entities.Result.ReactionTime') | The reaction time at the start. For relay events it is the reaction time of the first swimmer. |
| [Relaypositions](Lenex.Domain.Entities.Result.Relaypositions.md 'Lenex.Domain.Entities.Result.Relaypositions') | The information about relay swimmers in this result. Only allowed for relay RESULT objects. |
| [ResultId](Lenex.Domain.Entities.Result.ResultId.md 'Lenex.Domain.Entities.Result.ResultId') | Each result needs a unique id which should be unique over a meet. |
| [Splits](Lenex.Domain.Entities.Result.Splits.md 'Lenex.Domain.Entities.Result.Splits') | The split times for the result. In a Lenex file, split times are always saved continuously. |
| [Status](Lenex.Domain.Entities.Result.Status.md 'Lenex.Domain.Entities.Result.Status') | This attribute is used for the result status information. An empty status attribute means a regular result. |
| [SwimDistance](Lenex.Domain.Entities.Result.SwimDistance.md 'Lenex.Domain.Entities.Result.SwimDistance') | The result distance in centimeters. Is used for some fin swimming events. For such results the swimtime should be "NT". |
| [SwimTime](Lenex.Domain.Entities.Result.SwimTime.md 'Lenex.Domain.Entities.Result.SwimTime') | The final time of the result in the swim time format. |
| [TagKey](Lenex.Domain.Entities.Result.TagKey.md 'Lenex.Domain.Entities.Result.TagKey') | Tag object for markings in user implementation. |

| Properties | |
| :--- | :--- |
| [HeatIdSpecified](Lenex.Domain.Entities.Result.HeatIdSpecified.md 'Lenex.Domain.Entities.Result.HeatIdSpecified') | |
| [HeatSpecified](Lenex.Domain.Entities.Result.HeatSpecified.md 'Lenex.Domain.Entities.Result.HeatSpecified') | |
| [LaneSpecified](Lenex.Domain.Entities.Result.LaneSpecified.md 'Lenex.Domain.Entities.Result.LaneSpecified') | |
| [PointsSpecified](Lenex.Domain.Entities.Result.PointsSpecified.md 'Lenex.Domain.Entities.Result.PointsSpecified') | |
| [StatusSpecified](Lenex.Domain.Entities.Result.StatusSpecified.md 'Lenex.Domain.Entities.Result.StatusSpecified') | |
| [SwimDistanceSpecified](Lenex.Domain.Entities.Result.SwimDistanceSpecified.md 'Lenex.Domain.Entities.Result.SwimDistanceSpecified') | |
