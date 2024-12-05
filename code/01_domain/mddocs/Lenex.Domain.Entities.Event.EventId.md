#### [Lenex.Domain](index.md 'index')
### [Lenex.Domain.Entities](Lenex.Domain.Entities.md 'Lenex.Domain.Entities').[Event](Lenex.Domain.Entities.Event.md 'Lenex.Domain.Entities.Event')

## Event.EventId Field

Every event needs to have an id attribute, so that it can be referenced by ENTRY and RESULT objects. The id attribute has to be unique over all EVENT objects of all sessions of a meet.

```csharp
public int EventId;
```

#### Field Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')