#### [Lenex.Domain](index.md 'index')
### [Lenex.Domain.Entities](Lenex.Domain.Entities.md 'Lenex.Domain.Entities')

## Heat Class

The heat is used to define more details in the start list (e.g. schedule).

```csharp
public class Heat
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Heat

| Fields | |
| :--- | :--- |
| [AgegroupId](Lenex.Domain.Entities.Heat.AgegroupId.md 'Lenex.Domain.Entities.Heat.AgegroupId') | Reference to an age group (AGEGROUP element in the AGEGROUPS collection of the EVENT element). |
| [Daytime](Lenex.Domain.Entities.Heat.Daytime.md 'Lenex.Domain.Entities.Heat.Daytime') | The daytime of the start of the event. |
| [Final](Lenex.Domain.Entities.Heat.Final.md 'Lenex.Domain.Entities.Heat.Final') | This value is used to identify A, B, ... finals. Allowed are characters A, B, C and D. |
| [HeatId](Lenex.Domain.Entities.Heat.HeatId.md 'Lenex.Domain.Entities.Heat.HeatId') | The id attribute should be unique over all heats of a meet. It is required when you have ENTRY / RESULT objects that reference to a heat. |
| [Number](Lenex.Domain.Entities.Heat.Number.md 'Lenex.Domain.Entities.Heat.Number') | The number of the heat. The heat numbers have to be unique within one event, also in a case when you have A finals in different agegroups. |
| [Order](Lenex.Domain.Entities.Heat.Order.md 'Lenex.Domain.Entities.Heat.Order') | This value can be used to define the order of the heats within an event if it is not by the heat number and if there are no start times for the heats. |
| [Status](Lenex.Domain.Entities.Heat.Status.md 'Lenex.Domain.Entities.Heat.Status') | The status of the heat. |
| [TagKey](Lenex.Domain.Entities.Heat.TagKey.md 'Lenex.Domain.Entities.Heat.TagKey') | Tag object for markings in user implementation. |

| Properties | |
| :--- | :--- |
| [AgegroupIdSpecified](Lenex.Domain.Entities.Heat.AgegroupIdSpecified.md 'Lenex.Domain.Entities.Heat.AgegroupIdSpecified') | |
| [OrderSpecified](Lenex.Domain.Entities.Heat.OrderSpecified.md 'Lenex.Domain.Entities.Heat.OrderSpecified') | |
| [StatusSpecified](Lenex.Domain.Entities.Heat.StatusSpecified.md 'Lenex.Domain.Entities.Heat.StatusSpecified') | |
