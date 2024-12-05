#### [Lenex.Domain](index.md 'index')
### [Lenex.Domain.Entities](Lenex.Domain.Entities.md 'Lenex.Domain.Entities').[Session](Lenex.Domain.Entities.Session.md 'Lenex.Domain.Entities.Session')

## Session.Fees Field

Fees used for this session. On this level, different global fees for clubs, athletes and relays are allowed. If there are fees that have to be paid per entry, the FEE element in the EVENT objects should be used.

```csharp
public List<Fee>? Fees;
```

#### Field Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[Fee](Lenex.Domain.Entities.Fee.md 'Lenex.Domain.Entities.Fee')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')