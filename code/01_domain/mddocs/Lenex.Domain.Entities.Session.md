#### [Lenex.Domain](index.md 'index')
### [Lenex.Domain.Entities](Lenex.Domain.Entities.md 'Lenex.Domain.Entities')

## Session Class

This element is used to describe one session of a meet.

```csharp
public class Session
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Session

| Fields | |
| :--- | :--- |
| [Course](Lenex.Domain.Entities.Session.Course.md 'Lenex.Domain.Entities.Session.Course') | With indicating a pool length per session, the global value of the meet can be overridden, e.g. if the prelim sessions are short course and the finals are long course. See section 5.4. for acceptable values. |
| [Date](Lenex.Domain.Entities.Session.Date.md 'Lenex.Domain.Entities.Session.Date') | The date of the session. |
| [Daytime](Lenex.Domain.Entities.Session.Daytime.md 'Lenex.Domain.Entities.Session.Daytime') | The daytime when the session starts. |
| [Endtime](Lenex.Domain.Entities.Session.Endtime.md 'Lenex.Domain.Entities.Session.Endtime') | The time when the session ended. |
| [Events](Lenex.Domain.Entities.Session.Events.md 'Lenex.Domain.Entities.Session.Events') | The events of the session. |
| [Fees](Lenex.Domain.Entities.Session.Fees.md 'Lenex.Domain.Entities.Session.Fees') | Fees used for this session. On this level, different global fees for clubs, athletes and relays are allowed. If there are fees that have to be paid per entry, the FEE element in the EVENT objects should be used. |
| [Judges](Lenex.Domain.Entities.Session.Judges.md 'Lenex.Domain.Entities.Session.Judges') | The judges of the session. |
| [MaxEntriesAthlete](Lenex.Domain.Entities.Session.MaxEntriesAthlete.md 'Lenex.Domain.Entities.Session.MaxEntriesAthlete') | The maximum number of individual entries per athlete in this session. |
| [MaxEntriesRelay](Lenex.Domain.Entities.Session.MaxEntriesRelay.md 'Lenex.Domain.Entities.Session.MaxEntriesRelay') | The maximum number of relay entries per club in this session. |
| [Name](Lenex.Domain.Entities.Session.Name.md 'Lenex.Domain.Entities.Session.Name') | Additional name for the session e.g. "Day 1 - Prelims". |
| [Number](Lenex.Domain.Entities.Session.Number.md 'Lenex.Domain.Entities.Session.Number') | The number of the session. Session numbers in a meet have to be unique. |
| [OfficialMeeting](Lenex.Domain.Entities.Session.OfficialMeeting.md 'Lenex.Domain.Entities.Session.OfficialMeeting') | The daytime when the officials meeting starts. |
| [Pool](Lenex.Domain.Entities.Session.Pool.md 'Lenex.Domain.Entities.Session.Pool') | The details about the pool, if they are different per session. Otherwise use the element in MEET. |
| [RemarksJudge](Lenex.Domain.Entities.Session.RemarksJudge.md 'Lenex.Domain.Entities.Session.RemarksJudge') | Additional remarks given by the referee. |
| [TagKey](Lenex.Domain.Entities.Session.TagKey.md 'Lenex.Domain.Entities.Session.TagKey') | Tag object for markings in user implementation. |
| [TeamLeaderMeeting](Lenex.Domain.Entities.Session.TeamLeaderMeeting.md 'Lenex.Domain.Entities.Session.TeamLeaderMeeting') | The daytime when the team leaders meeting starts. |
| [Timing](Lenex.Domain.Entities.Session.Timing.md 'Lenex.Domain.Entities.Session.Timing') | The type of timing for a session. If missing, the global value for the meet should be used. See MEET for acceptable values. |
| [TouchpadMode](Lenex.Domain.Entities.Session.TouchpadMode.md 'Lenex.Domain.Entities.Session.TouchpadMode') | Information about timing installation for a meet. |
| [WarmupFrom](Lenex.Domain.Entities.Session.WarmupFrom.md 'Lenex.Domain.Entities.Session.WarmupFrom') | The daytime when the warmup starts. |
| [WarmupUntil](Lenex.Domain.Entities.Session.WarmupUntil.md 'Lenex.Domain.Entities.Session.WarmupUntil') | The daytime when the warmup ends. |

| Properties | |
| :--- | :--- |
| [CourseSpecified](Lenex.Domain.Entities.Session.CourseSpecified.md 'Lenex.Domain.Entities.Session.CourseSpecified') | |
| [MaxEntriesAthleteSpecified](Lenex.Domain.Entities.Session.MaxEntriesAthleteSpecified.md 'Lenex.Domain.Entities.Session.MaxEntriesAthleteSpecified') | |
| [MaxEntriesRelaySpecified](Lenex.Domain.Entities.Session.MaxEntriesRelaySpecified.md 'Lenex.Domain.Entities.Session.MaxEntriesRelaySpecified') | |
| [TimingSpecified](Lenex.Domain.Entities.Session.TimingSpecified.md 'Lenex.Domain.Entities.Session.TimingSpecified') | |
| [TouchpadModeSpecified](Lenex.Domain.Entities.Session.TouchpadModeSpecified.md 'Lenex.Domain.Entities.Session.TouchpadModeSpecified') | |

| Methods | |
| :--- | :--- |
| [SetDate(DateTime)](Lenex.Domain.Entities.Session.SetDate(System.DateTime).md 'Lenex.Domain.Entities.Session.SetDate(System.DateTime)') | This functions set the property Date and Daytime. |
