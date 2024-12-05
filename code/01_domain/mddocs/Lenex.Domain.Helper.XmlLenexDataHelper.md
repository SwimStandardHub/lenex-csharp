#### [Lenex.Domain](index.md 'index')
### [Lenex.Domain.Helper](Lenex.Domain.Helper.md 'Lenex.Domain.Helper')

## XmlLenexDataHelper Class

Class with helper function to parse and format Lenex data.

```csharp
public static class XmlLenexDataHelper
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; XmlLenexDataHelper

| Methods | |
| :--- | :--- |
| [GetDateTime(string)](Lenex.Domain.Helper.XmlLenexDataHelper.GetDateTime(string).md 'Lenex.Domain.Helper.XmlLenexDataHelper.GetDateTime(string)') | Get a DateTime from a Lenex Date |
| [GetDateTime(string, string)](Lenex.Domain.Helper.XmlLenexDataHelper.GetDateTime(string,string).md 'Lenex.Domain.Helper.XmlLenexDataHelper.GetDateTime(string, string)') | Get a DateTime from a Lenex Date and Daytime |
| [GetLenexDate(DateTime)](Lenex.Domain.Helper.XmlLenexDataHelper.GetLenexDate(System.DateTime).md 'Lenex.Domain.Helper.XmlLenexDataHelper.GetLenexDate(System.DateTime)') | Get a Lenex Date string<br/><br/>Dates are always represented by a string in the form "YYYY-MM-DD". Example: "2004-03-09" means March 9, 2004 |
| [GetLenexDaytime(DateTime)](Lenex.Domain.Helper.XmlLenexDataHelper.GetLenexDaytime(System.DateTime).md 'Lenex.Domain.Helper.XmlLenexDataHelper.GetLenexDaytime(System.DateTime)') | Get a Lenex Daytime string<br/><br/>A daytime (hour and minutes) represented by a string in the form "HH:MM". Hours should be from 0 to 24, minutes from 0 to 59. |
| [GetReactiontime(string)](Lenex.Domain.Helper.XmlLenexDataHelper.GetReactiontime(string).md 'Lenex.Domain.Helper.XmlLenexDataHelper.GetReactiontime(string)') | Get a ReactionTime in the Lenex format |
| [GetSwimTimeString(int, bool)](Lenex.Domain.Helper.XmlLenexDataHelper.GetSwimTimeString(int,bool).md 'Lenex.Domain.Helper.XmlLenexDataHelper.GetSwimTimeString(int, bool)') | Get a SwimTime in the Lenex format |
| [GetSwimTimeValue(string)](Lenex.Domain.Helper.XmlLenexDataHelper.GetSwimTimeValue(string).md 'Lenex.Domain.Helper.XmlLenexDataHelper.GetSwimTimeValue(string)') | Get a SwimTime from a Lenex SwimTime |
