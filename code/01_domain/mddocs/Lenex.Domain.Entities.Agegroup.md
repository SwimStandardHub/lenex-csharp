#### [Lenex.Domain](index.md 'index')
### [Lenex.Domain.Entities](Lenex.Domain.Entities.md 'Lenex.Domain.Entities')

## Agegroup Class

This element contains information about an age range. It is used in events and record lists.

```csharp
public class Agegroup
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Agegroup

| Fields | |
| :--- | :--- |
| [AgegroupId](Lenex.Domain.Entities.Agegroup.AgegroupId.md 'Lenex.Domain.Entities.Agegroup.AgegroupId') | Only for events, every AGEGROUP element needs an id, because the objects can be referenced from ENTRY objects. The id has to be unique within an AGEGROUPS collection. |
| [Agemax](Lenex.Domain.Entities.Agegroup.Agemax.md 'Lenex.Domain.Entities.Agegroup.Agemax') | The upper bound of the age range. -1 means no upper bound. |
| [Agemin](Lenex.Domain.Entities.Agegroup.Agemin.md 'Lenex.Domain.Entities.Agegroup.Agemin') | The lower bound of the age range. -1 means no lower bound. |
| [Calculate](Lenex.Domain.Entities.Agegroup.Calculate.md 'Lenex.Domain.Entities.Agegroup.Calculate') | Information for relay events about how the age is calculated. |
| [Gender](Lenex.Domain.Entities.Agegroup.Gender.md 'Lenex.Domain.Entities.Agegroup.Gender') | In mixed events, the gender can be specifiedin the AGEGROUP objects. Values can be male (M), female (F) or mixed (X). Mixed is only used for relays. This can be useful to define events with gender set to all (A), but the ranking is separated. This attribute is not allowed in the context of a RECORDLIST or TIMESTANDARDLIST element. |
| [Handicap](Lenex.Domain.Entities.Agegroup.Handicap.md 'Lenex.Domain.Entities.Agegroup.Handicap') | The handicap class for the agegroup. This is used to group results by disability categories. |
| [LevelMax](Lenex.Domain.Entities.Agegroup.LevelMax.md 'Lenex.Domain.Entities.Agegroup.LevelMax') | The maximum level (A-Z) of the agegroup. If the value is missing, this means no upper bound. |
| [LevelMin](Lenex.Domain.Entities.Agegroup.LevelMin.md 'Lenex.Domain.Entities.Agegroup.LevelMin') | The minimum level (A-Z) of the agegroup. If the value is missing, this means no lower bound. |
| [Levels](Lenex.Domain.Entities.Agegroup.Levels.md 'Lenex.Domain.Entities.Agegroup.Levels') | Comma separated list of codes of allowed athlete levels. |
| [Name](Lenex.Domain.Entities.Agegroup.Name.md 'Lenex.Domain.Entities.Agegroup.Name') | The name of the age group (e.g. "Juniors"). |
| [Rankings](Lenex.Domain.Entities.Agegroup.Rankings.md 'Lenex.Domain.Entities.Agegroup.Rankings') | A collection with references to results ranked in this agegroup. |
| [TagKey](Lenex.Domain.Entities.Agegroup.TagKey.md 'Lenex.Domain.Entities.Agegroup.TagKey') | Tag object for markings in user implementation. |

| Properties | |
| :--- | :--- |
| [CalculateSpecified](Lenex.Domain.Entities.Agegroup.CalculateSpecified.md 'Lenex.Domain.Entities.Agegroup.CalculateSpecified') | |
| [GenderSpecified](Lenex.Domain.Entities.Agegroup.GenderSpecified.md 'Lenex.Domain.Entities.Agegroup.GenderSpecified') | |
| [HandicapSpecified](Lenex.Domain.Entities.Agegroup.HandicapSpecified.md 'Lenex.Domain.Entities.Agegroup.HandicapSpecified') | |
