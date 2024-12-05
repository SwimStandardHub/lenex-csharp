#### [Lenex.Domain](index.md 'index')
### [Lenex.Domain.Entities](Lenex.Domain.Entities.md 'Lenex.Domain.Entities')

## Athlete Class

This contains all information of a athlete including all entries and results in the context of a meet sub tree.

```csharp
public class Athlete
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Athlete

| Fields | |
| :--- | :--- |
| [AthleteId](Lenex.Domain.Entities.Athlete.AthleteId.md 'Lenex.Domain.Entities.Athlete.AthleteId') | The id attribute should be unique over all athletes of a meet. It is required for ATHLETE objects in a meet sub tree. |
| [Birthdate](Lenex.Domain.Entities.Athlete.Birthdate.md 'Lenex.Domain.Entities.Athlete.Birthdate') | The date of birth for the athlete. If only the year of birth is known, the date should be set to January 1st of that year. |
| [Club](Lenex.Domain.Entities.Athlete.Club.md 'Lenex.Domain.Entities.Athlete.Club') | The club or team for the athlete, when he swam the record. |
| [Entries](Lenex.Domain.Entities.Athlete.Entries.md 'Lenex.Domain.Entities.Athlete.Entries') | All entries of the athlete. |
| [Firstname](Lenex.Domain.Entities.Athlete.Firstname.md 'Lenex.Domain.Entities.Athlete.Firstname') | The first name of the athlete. |
| [FirstnameEn](Lenex.Domain.Entities.Athlete.FirstnameEn.md 'Lenex.Domain.Entities.Athlete.FirstnameEn') | The first name in english. |
| [Gender](Lenex.Domain.Entities.Athlete.Gender.md 'Lenex.Domain.Entities.Athlete.Gender') | Gender of the athlete. |
| [Handicap](Lenex.Domain.Entities.Athlete.Handicap.md 'Lenex.Domain.Entities.Athlete.Handicap') | Information about the handicap classes of a swimmer. |
| [Lastname](Lenex.Domain.Entities.Athlete.Lastname.md 'Lenex.Domain.Entities.Athlete.Lastname') | The last name of the athlete. |
| [LastnameEn](Lenex.Domain.Entities.Athlete.LastnameEn.md 'Lenex.Domain.Entities.Athlete.LastnameEn') | The last name in english. |
| [Level](Lenex.Domain.Entities.Athlete.Level.md 'Lenex.Domain.Entities.Athlete.Level') | The level of the athlete (used with levels in AGEGROUP). |
| [License](Lenex.Domain.Entities.Athlete.License.md 'Lenex.Domain.Entities.Athlete.License') | The registration number given by the national federation. This number should be looked at together with the nation of the club the athlete is listed in the Lenex file. |
| [LicenseDbs](Lenex.Domain.Entities.Athlete.LicenseDbs.md 'Lenex.Domain.Entities.Athlete.LicenseDbs') | The registration number given by Deutscher Behinderten Sportverband. |
| [LicenseDsv](Lenex.Domain.Entities.Athlete.LicenseDsv.md 'Lenex.Domain.Entities.Athlete.LicenseDsv') | The registration number given by Deutscher Behinderten Sportverband. |
| [LicenseIpc](Lenex.Domain.Entities.Athlete.LicenseIpc.md 'Lenex.Domain.Entities.Athlete.LicenseIpc') | The registration number given by World Para Swimming, also known as SDMS ID. |
| [Nameprefix](Lenex.Domain.Entities.Athlete.Nameprefix.md 'Lenex.Domain.Entities.Athlete.Nameprefix') | An optional name prefix. For example for Peter van den Hoogenband, this could be "van den". |
| [Nation](Lenex.Domain.Entities.Athlete.Nation.md 'Lenex.Domain.Entities.Athlete.Nation') | See table "Nation Codes" for acceptable values. |
| [Passport](Lenex.Domain.Entities.Athlete.Passport.md 'Lenex.Domain.Entities.Athlete.Passport') | The passport number of the athlete. |
| [Results](Lenex.Domain.Entities.Athlete.Results.md 'Lenex.Domain.Entities.Athlete.Results') | All results of the athlete. |
| [Status](Lenex.Domain.Entities.Athlete.Status.md 'Lenex.Domain.Entities.Athlete.Status') | |
| [Swrid](Lenex.Domain.Entities.Athlete.Swrid.md 'Lenex.Domain.Entities.Athlete.Swrid') | The global unique athlete id given by swimrankings.net. |
| [TagKey](Lenex.Domain.Entities.Athlete.TagKey.md 'Lenex.Domain.Entities.Athlete.TagKey') | Tag object for markings in user implementation. |

| Properties | |
| :--- | :--- |
| [NationSpecified](Lenex.Domain.Entities.Athlete.NationSpecified.md 'Lenex.Domain.Entities.Athlete.NationSpecified') | |
| [StatusSpecified](Lenex.Domain.Entities.Athlete.StatusSpecified.md 'Lenex.Domain.Entities.Athlete.StatusSpecified') | |

| Methods | |
| :--- | :--- |
| [GetBirthdate()](Lenex.Domain.Entities.Athlete.GetBirthdate().md 'Lenex.Domain.Entities.Athlete.GetBirthdate()') | This function get the Birthdate as DateTime. |
| [SetBirthdate(DateTime)](Lenex.Domain.Entities.Athlete.SetBirthdate(System.DateTime).md 'Lenex.Domain.Entities.Athlete.SetBirthdate(System.DateTime)') | This functions set the property Birthdate. |
