#### [Lenex.Domain](index.md 'index')
### [Lenex.Domain.Entities](Lenex.Domain.Entities.md 'Lenex.Domain.Entities')

## Meet Class

This element contains all information of one meet, including events, athletes, relays, entries and results.

```csharp
public class Meet
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Meet

| Fields | |
| :--- | :--- |
| [Agedate](Lenex.Domain.Entities.Meet.Agedate.md 'Lenex.Domain.Entities.Meet.Agedate') | The date to be used to calculate the age of athletes. The default value is the date of the first session and type by year of birth only. |
| [Altitude](Lenex.Domain.Entities.Meet.Altitude.md 'Lenex.Domain.Entities.Meet.Altitude') | Height above sea level of the meet city. |
| [Bank](Lenex.Domain.Entities.Meet.Bank.md 'Lenex.Domain.Entities.Meet.Bank') | Information for a bank account for payment of entry fees. |
| [City](Lenex.Domain.Entities.Meet.City.md 'Lenex.Domain.Entities.Meet.City') | The name of the city where the meet was run. Should be the same as FACILITY.city |
| [CityEn](Lenex.Domain.Entities.Meet.CityEn.md 'Lenex.Domain.Entities.Meet.CityEn') | Name of meet city in english. |
| [Clubs](Lenex.Domain.Entities.Meet.Clubs.md 'Lenex.Domain.Entities.Meet.Clubs') | Collection of clubs of the meet. |
| [Contact](Lenex.Domain.Entities.Meet.Contact.md 'Lenex.Domain.Entities.Meet.Contact') | The contact address of the meet organizer. |
| [Course](Lenex.Domain.Entities.Meet.Course.md 'Lenex.Domain.Entities.Meet.Course') | The size of the pool. If the attribute is not available, all SESSION objects need to have a course attribute. |
| [DeadLine](Lenex.Domain.Entities.Meet.DeadLine.md 'Lenex.Domain.Entities.Meet.DeadLine') | The date for the entry deadline. |
| [DeadLineTime](Lenex.Domain.Entities.Meet.DeadLineTime.md 'Lenex.Domain.Entities.Meet.DeadLineTime') | The exact time for the entry deadline. |
| [EntryStartDate](Lenex.Domain.Entities.Meet.EntryStartDate.md 'Lenex.Domain.Entities.Meet.EntryStartDate') | The date from when (online) entries are open/available. |
| [EntryType](Lenex.Domain.Entities.Meet.EntryType.md 'Lenex.Domain.Entities.Meet.EntryType') | The type of (online) entries |
| [Facility](Lenex.Domain.Entities.Meet.Facility.md 'Lenex.Domain.Entities.Meet.Facility') | The full address of the meets facility. |
| [Fees](Lenex.Domain.Entities.Meet.Fees.md 'Lenex.Domain.Entities.Meet.Fees') | Fees used for this meet. On this level, different global fees for clubs, athletes and relays are allowed. If there are fees that have to be paid per entry, the FEE element in the EVENT objects should be used. |
| [HostClub](Lenex.Domain.Entities.Meet.HostClub.md 'Lenex.Domain.Entities.Meet.HostClub') | The executing federation or club of the meet (e.g. the German Swimming Federation, if the European Champ was held in Berlin). |
| [HostClubUrl](Lenex.Domain.Entities.Meet.HostClubUrl.md 'Lenex.Domain.Entities.Meet.HostClubUrl') | A website url, that directs to the executing club for the meet |
| [MaxEntriesAthlete](Lenex.Domain.Entities.Meet.MaxEntriesAthlete.md 'Lenex.Domain.Entities.Meet.MaxEntriesAthlete') | The maximum number of individual entries per athlete in this meet. |
| [MaxEntriesRelay](Lenex.Domain.Entities.Meet.MaxEntriesRelay.md 'Lenex.Domain.Entities.Meet.MaxEntriesRelay') | The maximum number of relay entries per club in this meet. |
| [Name](Lenex.Domain.Entities.Meet.Name.md 'Lenex.Domain.Entities.Meet.Name') | The name of the meet. Normally the name should not contain a full date (maybe the year only) and/or a city or pool name. |
| [NameEn](Lenex.Domain.Entities.Meet.NameEn.md 'Lenex.Domain.Entities.Meet.NameEn') | Meet name in english. |
| [Nation](Lenex.Domain.Entities.Meet.Nation.md 'Lenex.Domain.Entities.Meet.Nation') | The three letter code of the nation of the meet city. This should be the same as FACILITY.nation |
| [Number](Lenex.Domain.Entities.Meet.Number.md 'Lenex.Domain.Entities.Meet.Number') | The sanction number for the meet by the federation. |
| [Organizer](Lenex.Domain.Entities.Meet.Organizer.md 'Lenex.Domain.Entities.Meet.Organizer') | The organisation which promotes the meet (e.g. FINA for the World Championships). |
| [OrganizerUrl](Lenex.Domain.Entities.Meet.OrganizerUrl.md 'Lenex.Domain.Entities.Meet.OrganizerUrl') | A website url, that directs to the organizer of the meet. |
| [Pointtable](Lenex.Domain.Entities.Meet.Pointtable.md 'Lenex.Domain.Entities.Meet.Pointtable') | Description of the point table used for scoring. |
| [Pool](Lenex.Domain.Entities.Meet.Pool.md 'Lenex.Domain.Entities.Meet.Pool') | Details about the pool where the meet took place. |
| [Qualify](Lenex.Domain.Entities.Meet.Qualify.md 'Lenex.Domain.Entities.Meet.Qualify') | Details about how qualification times for entries are defined. |
| [ReserveCount](Lenex.Domain.Entities.Meet.ReserveCount.md 'Lenex.Domain.Entities.Meet.ReserveCount') | The number of reserve swimmers in finals and semifinals. |
| [ResultUrl](Lenex.Domain.Entities.Meet.ResultUrl.md 'Lenex.Domain.Entities.Meet.ResultUrl') | A website url, that directs to the results page. This should be a deep (direct) link to the result lists and not the general website of a meet. |
| [Sessions](Lenex.Domain.Entities.Meet.Sessions.md 'Lenex.Domain.Entities.Meet.Sessions') | Description of all events grouped by session. |
| [Startmethode](Lenex.Domain.Entities.Meet.Startmethode.md 'Lenex.Domain.Entities.Meet.Startmethode') | 1 start rule or 2 start rule. |
| [SwrId](Lenex.Domain.Entities.Meet.SwrId.md 'Lenex.Domain.Entities.Meet.SwrId') | The global unique meet id given by swimrankings.net. |
| [TagKey](Lenex.Domain.Entities.Meet.TagKey.md 'Lenex.Domain.Entities.Meet.TagKey') | Tag object for markings in user implementation. |
| [Timing](Lenex.Domain.Entities.Meet.Timing.md 'Lenex.Domain.Entities.Meet.Timing') | The type of timing for a meet. |
| [TouchpadMode](Lenex.Domain.Entities.Meet.TouchpadMode.md 'Lenex.Domain.Entities.Meet.TouchpadMode') | Information about timing installation for a meet. |
| [WithDrawUntil](Lenex.Domain.Entities.Meet.WithDrawUntil.md 'Lenex.Domain.Entities.Meet.WithDrawUntil') | The date for withdrawals from the entry list. |

| Properties | |
| :--- | :--- |
| [AltitudeSpecified](Lenex.Domain.Entities.Meet.AltitudeSpecified.md 'Lenex.Domain.Entities.Meet.AltitudeSpecified') | |
| [CourseSpecified](Lenex.Domain.Entities.Meet.CourseSpecified.md 'Lenex.Domain.Entities.Meet.CourseSpecified') | |
| [EntryTypeSpecified](Lenex.Domain.Entities.Meet.EntryTypeSpecified.md 'Lenex.Domain.Entities.Meet.EntryTypeSpecified') | |
| [MaxEntriesAthleteSpecified](Lenex.Domain.Entities.Meet.MaxEntriesAthleteSpecified.md 'Lenex.Domain.Entities.Meet.MaxEntriesAthleteSpecified') | |
| [MaxEntriesRelaySpecified](Lenex.Domain.Entities.Meet.MaxEntriesRelaySpecified.md 'Lenex.Domain.Entities.Meet.MaxEntriesRelaySpecified') | |
| [NationSpecified](Lenex.Domain.Entities.Meet.NationSpecified.md 'Lenex.Domain.Entities.Meet.NationSpecified') | |
| [ReserveCountSpecified](Lenex.Domain.Entities.Meet.ReserveCountSpecified.md 'Lenex.Domain.Entities.Meet.ReserveCountSpecified') | |
| [StartmethodeSpecified](Lenex.Domain.Entities.Meet.StartmethodeSpecified.md 'Lenex.Domain.Entities.Meet.StartmethodeSpecified') | |
| [TimingSpecified](Lenex.Domain.Entities.Meet.TimingSpecified.md 'Lenex.Domain.Entities.Meet.TimingSpecified') | |
| [TouchpadModeSpecified](Lenex.Domain.Entities.Meet.TouchpadModeSpecified.md 'Lenex.Domain.Entities.Meet.TouchpadModeSpecified') | |

| Methods | |
| :--- | :--- |
| [GetDeadLine()](Lenex.Domain.Entities.Meet.GetDeadLine().md 'Lenex.Domain.Entities.Meet.GetDeadLine()') | This function get the Deadline as DateTime. |
| [SetDeadLine(DateTime)](Lenex.Domain.Entities.Meet.SetDeadLine(System.DateTime).md 'Lenex.Domain.Entities.Meet.SetDeadLine(System.DateTime)') | This functions set the property DeadLine and DeadLineTime. |
| [SetEntryStartDate(DateTime)](Lenex.Domain.Entities.Meet.SetEntryStartDate(System.DateTime).md 'Lenex.Domain.Entities.Meet.SetEntryStartDate(System.DateTime)') | This functions set the property EntryStartDate. |
| [WithDrawUntilDate(DateTime)](Lenex.Domain.Entities.Meet.WithDrawUntilDate(System.DateTime).md 'Lenex.Domain.Entities.Meet.WithDrawUntilDate(System.DateTime)') | This functions set the property WithDrawUntil. |
