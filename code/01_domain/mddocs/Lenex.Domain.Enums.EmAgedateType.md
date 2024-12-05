#### [Lenex.Domain](index.md 'index')
### [Lenex.Domain.Enums](Lenex.Domain.Enums.md 'Lenex.Domain.Enums')

## EmAgedateType Enum

The type describes, how the age is calculated.

```csharp
public enum EmAgedateType
```
### Fields

<a name='Lenex.Domain.Enums.EmAgedateType.CAN_FNQ'></a>

`CAN_FNQ` 3

Calculation according the Quebec federation.

<a name='Lenex.Domain.Enums.EmAgedateType.DATE'></a>

`DATE` 1

The age is calculated exactly between the date and the birth date.

<a name='Lenex.Domain.Enums.EmAgedateType.LUX'></a>

`LUX` 4

Calculation according the Luxembourg federation.

<a name='Lenex.Domain.Enums.EmAgedateType.POR'></a>

`POR` 2

Age calculation according the Portuguese federation.

<a name='Lenex.Domain.Enums.EmAgedateType.YEAR'></a>

`YEAR` 0

The age is calculated using the year of the meet and the year of birth only.