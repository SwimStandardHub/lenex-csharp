#### [Lenex.Domain](index.md 'index')
### [Lenex.Domain.Entities](Lenex.Domain.Entities.md 'Lenex.Domain.Entities')

## Club Class

In the meet sub tree, this element contains information about a club, including athletes and relays with their entries and/or results. In the record list sub tree, the element contains information about the club or nation of record holders.

```csharp
public class Club
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Club

| Fields | |
| :--- | :--- |
| [Athletes](Lenex.Domain.Entities.Club.Athletes.md 'Lenex.Domain.Entities.Club.Athletes') | The athletes of this club. |
| [Code](Lenex.Domain.Entities.Club.Code.md 'Lenex.Domain.Entities.Club.Code') | The official club code given by the national federation. Only official club codes should be used here! |
| [Contact](Lenex.Domain.Entities.Club.Contact.md 'Lenex.Domain.Entities.Club.Contact') | Contact address for the specific meet. |
| [Name](Lenex.Domain.Entities.Club.Name.md 'Lenex.Domain.Entities.Club.Name') | The full name of the club or the team. |
| [NameEn](Lenex.Domain.Entities.Club.NameEn.md 'Lenex.Domain.Entities.Club.NameEn') | The club name in english. |
| [Nation](Lenex.Domain.Entities.Club.Nation.md 'Lenex.Domain.Entities.Club.Nation') | See table "Nation Codes" for acceptable values. |
| [Number](Lenex.Domain.Entities.Club.Number.md 'Lenex.Domain.Entities.Club.Number') | This value can be used to distinguish different teams of the same club in a meet entries or results file. |
| [Officials](Lenex.Domain.Entities.Club.Officials.md 'Lenex.Domain.Entities.Club.Officials') | The officials from this club. |
| [Region](Lenex.Domain.Entities.Club.Region.md 'Lenex.Domain.Entities.Club.Region') | The code of the regional or local swimming committee. Only official codes should be used here! |
| [Relays](Lenex.Domain.Entities.Club.Relays.md 'Lenex.Domain.Entities.Club.Relays') | The relay teams of this club. |
| [ShortName](Lenex.Domain.Entities.Club.ShortName.md 'Lenex.Domain.Entities.Club.ShortName') | A short version of the club name. This string is limited to 20 characters. |
| [ShortNameEn](Lenex.Domain.Entities.Club.ShortNameEn.md 'Lenex.Domain.Entities.Club.ShortNameEn') | The short version of the club name in english. |
| [Swrid](Lenex.Domain.Entities.Club.Swrid.md 'Lenex.Domain.Entities.Club.Swrid') | The global unique club id given by swimrankings.net. |
| [TagKey](Lenex.Domain.Entities.Club.TagKey.md 'Lenex.Domain.Entities.Club.TagKey') | Tag object for markings in user implementation. |
| [Type](Lenex.Domain.Entities.Club.Type.md 'Lenex.Domain.Entities.Club.Type') | Type of the team. |

| Properties | |
| :--- | :--- |
| [NationSpecified](Lenex.Domain.Entities.Club.NationSpecified.md 'Lenex.Domain.Entities.Club.NationSpecified') | |
| [NumberSpecified](Lenex.Domain.Entities.Club.NumberSpecified.md 'Lenex.Domain.Entities.Club.NumberSpecified') | |
| [TypeSpecified](Lenex.Domain.Entities.Club.TypeSpecified.md 'Lenex.Domain.Entities.Club.TypeSpecified') | |
