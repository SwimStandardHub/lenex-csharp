#### [Lenex.Domain](index.md 'index')
### [Lenex.Domain.Entities](Lenex.Domain.Entities.md 'Lenex.Domain.Entities').[Event](Lenex.Domain.Entities.Event.md 'Lenex.Domain.Entities.Event')

## Event.PrevEventId Field

This value is a reference to a previous event's id. (e.g. the prelims events for final events). The default value is -1 and means, that there was no previous event.

```csharp
public int PrevEventId;
```

#### Field Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')