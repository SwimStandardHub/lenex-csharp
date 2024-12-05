#### [Lenex.Domain](index.md 'index')
### [Lenex.Domain.Entities](Lenex.Domain.Entities.md 'Lenex.Domain.Entities').[Event](Lenex.Domain.Entities.Event.md 'Lenex.Domain.Entities.Event')

## Event.Agegroups Field

The AGEGROUPS collection contains the descriptions for the age groups in this event. For Open/Senior events, AGEGROUPS is only needed with one AGEGROUP element as a placeholder for the RANKINGS element (for places in result lists). If round="FHT", then no AGEGROUPS element is allowed.

```csharp
public List<Agegroup>? Agegroups;
```

#### Field Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[Agegroup](Lenex.Domain.Entities.Agegroup.md 'Lenex.Domain.Entities.Agegroup')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')