#### [Lenex.Domain](index.md 'index')
### [Lenex.Domain.Entities](Lenex.Domain.Entities.md 'Lenex.Domain.Entities')

## Swimstyle Class

This element is used to describe one swim style.

```csharp
public class Swimstyle
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Swimstyle

| Fields | |
| :--- | :--- |
| [Code](Lenex.Domain.Entities.Swimstyle.Code.md 'Lenex.Domain.Entities.Swimstyle.Code') | A code (max. 6 characters) of the swim style if the stroke is unknown. |
| [Distance](Lenex.Domain.Entities.Swimstyle.Distance.md 'Lenex.Domain.Entities.Swimstyle.Distance') | The distance for the event. For relay events it is the distance for one single athlete. |
| [Name](Lenex.Domain.Entities.Swimstyle.Name.md 'Lenex.Domain.Entities.Swimstyle.Name') | The full descriptive name of the swim style if the stroke is unknown (e.g. "5 x 75m Breast with one Arm only"). |
| [Relaycount](Lenex.Domain.Entities.Swimstyle.Relaycount.md 'Lenex.Domain.Entities.Swimstyle.Relaycount') | The number of swimmers per entry / result. Value 1 means, that it is an individual event. All other values mean, that it is a relay event. |
| [Stroke](Lenex.Domain.Entities.Swimstyle.Stroke.md 'Lenex.Domain.Entities.Swimstyle.Stroke') | The Swimstyle. |
| [SwimstyleId](Lenex.Domain.Entities.Swimstyle.SwimstyleId.md 'Lenex.Domain.Entities.Swimstyle.SwimstyleId') | The id attribute is important for SWIMSTYLE objects, where the stroke attribute is "UNKNOWN". In this case, the id should be a unique value to help to identify the swim style. |
| [TagKey](Lenex.Domain.Entities.Swimstyle.TagKey.md 'Lenex.Domain.Entities.Swimstyle.TagKey') | Tag object for markings in user implementation. |
| [Technique](Lenex.Domain.Entities.Swimstyle.Technique.md 'Lenex.Domain.Entities.Swimstyle.Technique') | The technique of the style. If this attribute is missing or empty, it means normal swimming. All other values are mainly used for technical events in meets for kids. |

| Properties | |
| :--- | :--- |
| [SwimstyleIdSpecified](Lenex.Domain.Entities.Swimstyle.SwimstyleIdSpecified.md 'Lenex.Domain.Entities.Swimstyle.SwimstyleIdSpecified') | |
| [TechniqueSpecified](Lenex.Domain.Entities.Swimstyle.TechniqueSpecified.md 'Lenex.Domain.Entities.Swimstyle.TechniqueSpecified') | |
