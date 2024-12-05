#### [Lenex.Domain](index.md 'index')
### [Lenex.Domain.Enums](Lenex.Domain.Enums.md 'Lenex.Domain.Enums')

## EmEventRound Enum

```csharp
public enum EmEventRound
```
### Fields

<a name='Lenex.Domain.Enums.EmEventRound.FHT'></a>

`FHT` 1

Fastest heats of an event with timed finals. Events with this value for round should always refer to the corresponding timed final event, which should be of the same distance, stroke and age groups. Events with round set to FHT only make sence for the schedule and ENTRY objects, but never to be used for RESULT's.

<a name='Lenex.Domain.Enums.EmEventRound.FIN'></a>

`FIN` 2

This is used for finals including A, B, C, … finals.

<a name='Lenex.Domain.Enums.EmEventRound.GERRES'></a>

`GERRES` 9

Germany: Reswim, Nachschwimmen

<a name='Lenex.Domain.Enums.EmEventRound.PRE'></a>

`PRE` 5

for prelims.

<a name='Lenex.Domain.Enums.EmEventRound.QUA'></a>

`QUA` 4

for quarterfinals.

<a name='Lenex.Domain.Enums.EmEventRound.SEM'></a>

`SEM` 3

for semi finals.

<a name='Lenex.Domain.Enums.EmEventRound.SOP'></a>

`SOP` 6

Swim-Off after prelims.

<a name='Lenex.Domain.Enums.EmEventRound.SOQ'></a>

`SOQ` 8

Swim-Off after quarterfinals.

<a name='Lenex.Domain.Enums.EmEventRound.SOS'></a>

`SOS` 7

Swim-Off after semi-finals.

<a name='Lenex.Domain.Enums.EmEventRound.TIM'></a>

`TIM` 0

This is the default value. Used for an event with timed finals.

<a name='Lenex.Domain.Enums.EmEventRound.TIMETRIAL'></a>

`TIMETRIAL` 10

a time trail (like a timed final without heats and time trail starts)