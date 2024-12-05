#### [Lenex.Domain](index.md 'index')
### [Lenex.Domain.Enums](Lenex.Domain.Enums.md 'Lenex.Domain.Enums')

## EmClubType Enum

The following types of clubs are allowed:

```csharp
public enum EmClubType
```
### Fields

<a name='Lenex.Domain.Enums.EmClubType.CLUB'></a>

`CLUB` 0

This is the default value.

<a name='Lenex.Domain.Enums.EmClubType.NATIONALTEAM'></a>

`NATIONALTEAM` 2

The club represents a national team of a federation. In this case, the code, region and nation attribute should be the same.

<a name='Lenex.Domain.Enums.EmClubType.NOC'></a>

`NOC` 1

The club represents a national team of a federation. In this case, the code, region and nation attribute should be the same.

<a name='Lenex.Domain.Enums.EmClubType.REGIONALTEAM'></a>

`REGIONALTEAM` 3

The club represents a regional team. In this case, the code and region attribute should be the same.

<a name='Lenex.Domain.Enums.EmClubType.UNATTACHED'></a>

`UNATTACHED` 4

To be used for the CLUB entry, that contains data of athletes, where the club is unknown. In this case, the attribute name and the CONTACT element are not required.