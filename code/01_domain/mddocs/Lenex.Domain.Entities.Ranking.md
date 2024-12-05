#### [Lenex.Domain](index.md 'index')
### [Lenex.Domain.Entities](Lenex.Domain.Entities.md 'Lenex.Domain.Entities')

## Ranking Class

This element describes one entry in the rankings of one agegroup. It contains the place and a reference to a result (individual or relay).

```csharp
public class Ranking
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Ranking

| Fields | |
| :--- | :--- |
| [Order](Lenex.Domain.Entities.Ranking.Order.md 'Lenex.Domain.Entities.Ranking.Order') | This value can be used to define the order of the results. If it is missing, the value for place is used to sort the elements in a collection. |
| [Place](Lenex.Domain.Entities.Ranking.Place.md 'Lenex.Domain.Entities.Ranking.Place') | The final position in the result list for the current event/round. |
| [ResultId](Lenex.Domain.Entities.Ranking.ResultId.md 'Lenex.Domain.Entities.Ranking.ResultId') | A reference to the RESULT element. |
| [TagKey](Lenex.Domain.Entities.Ranking.TagKey.md 'Lenex.Domain.Entities.Ranking.TagKey') | Tag object for markings in user implementation. |

| Properties | |
| :--- | :--- |
| [OrderSpecified](Lenex.Domain.Entities.Ranking.OrderSpecified.md 'Lenex.Domain.Entities.Ranking.OrderSpecified') | |
