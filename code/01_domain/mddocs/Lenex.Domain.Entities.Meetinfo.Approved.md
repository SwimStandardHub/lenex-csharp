#### [Lenex.Domain](index.md 'index')
### [Lenex.Domain.Entities](Lenex.Domain.Entities.md 'Lenex.Domain.Entities').[Meetinfo](Lenex.Domain.Entities.Meetinfo.md 'Lenex.Domain.Entities.Meetinfo')

## Meetinfo.Approved Field

Contains a code for the organisation, who approved the qualification time, e.g. FINA, LEN or a IOC nation code. If this field is empty, the qualification time was not approved.

```csharp
public string? Approved;
```

#### Field Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

### Remarks
These elements are used in the context of a ENTRY / RELAYPOSITION element only.