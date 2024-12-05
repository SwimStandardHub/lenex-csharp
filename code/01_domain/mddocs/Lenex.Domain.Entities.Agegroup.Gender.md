#### [Lenex.Domain](index.md 'index')
### [Lenex.Domain.Entities](Lenex.Domain.Entities.md 'Lenex.Domain.Entities').[Agegroup](Lenex.Domain.Entities.Agegroup.md 'Lenex.Domain.Entities.Agegroup')

## Agegroup.Gender Field

In mixed events, the gender can be specifiedin the AGEGROUP objects. Values can be male (M), female (F) or mixed (X). Mixed is only used for relays. This can be useful to define events with gender set to all (A), but the ranking is separated. This attribute is not allowed in the context of a RECORDLIST or TIMESTANDARDLIST element.

```csharp
public EmSportGender Gender;
```

#### Field Value
[EmSportGender](Lenex.Domain.Enums.EmSportGender.md 'Lenex.Domain.Enums.EmSportGender')