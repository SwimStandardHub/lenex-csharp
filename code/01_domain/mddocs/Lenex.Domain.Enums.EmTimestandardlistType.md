#### [Lenex.Domain](index.md 'index')
### [Lenex.Domain.Enums](Lenex.Domain.Enums.md 'Lenex.Domain.Enums')

## EmTimestandardlistType Enum

There can be different type of time standards. Default value is MAXIMUM.

```csharp
public enum EmTimestandardlistType
```
### Fields

<a name='Lenex.Domain.Enums.EmTimestandardlistType.DEFAULT'></a>

`DEFAULT` 1

The time standards describe a set of default times, that may be used in a team competition, where a result for an event of a team is missing or invalid and therefore is replaced by this default time.

<a name='Lenex.Domain.Enums.EmTimestandardlistType.MAXIMUM'></a>

`MAXIMUM` 2

The time standards describe a maximal time for a meet. Swimmers can only compete, when they are faster than the time standards.

<a name='Lenex.Domain.Enums.EmTimestandardlistType.MINIMUM'></a>

`MINIMUM` 3

The time standards describe a minimal time for a meet. Swimmers can only compete, when they are slower than the time standards.

<a name='Lenex.Domain.Enums.EmTimestandardlistType.None'></a>

`None` 0