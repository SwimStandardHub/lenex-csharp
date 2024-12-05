#### [Lenex.Domain](index.md 'index')
### [Lenex.Domain.Enums](Lenex.Domain.Enums.md 'Lenex.Domain.Enums')

## EmQualifyConversion Enum

The way, how times are converted for seeding.

```csharp
public enum EmQualifyConversion
```
### Fields

<a name='Lenex.Domain.Enums.EmQualifyConversion.FINA_POINTS'></a>

`FINA_POINTS` 1

Entry times, flaged with a course other than the event course will be converted by calculating the FINA points and from there calculating back to a swim time.

<a name='Lenex.Domain.Enums.EmQualifyConversion.NON_CONFORMING_LAST'></a>

`NON_CONFORMING_LAST` 3

In this case, entries that are flaged with the event course will be seeded first, all other entries will be seeded after these.

<a name='Lenex.Domain.Enums.EmQualifyConversion.NONE'></a>

`NONE` 0

This is the default value. No conversion will be done.

<a name='Lenex.Domain.Enums.EmQualifyConversion.PERCENT_LINEAR'></a>

`PERCENT_LINEAR` 2

Here the conversion will be done by adding / subtracting a certain percantage to the original entry time.