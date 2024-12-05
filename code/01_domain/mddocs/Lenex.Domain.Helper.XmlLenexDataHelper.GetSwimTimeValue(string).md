#### [Lenex.Domain](index.md 'index')
### [Lenex.Domain.Helper](Lenex.Domain.Helper.md 'Lenex.Domain.Helper').[XmlLenexDataHelper](Lenex.Domain.Helper.XmlLenexDataHelper.md 'Lenex.Domain.Helper.XmlLenexDataHelper')

## XmlLenexDataHelper.GetSwimTimeValue(string) Method

Get a SwimTime from a Lenex SwimTime

```csharp
public static int GetSwimTimeValue(string? swimTime);
```
#### Parameters

<a name='Lenex.Domain.Helper.XmlLenexDataHelper.GetSwimTimeValue(string).swimTime'></a>

`swimTime` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The swim time data type is always a fixed length string of the following form: "HH:MM:SS.ss".  
            HH: hours from 0 to 99, MM: minutes from 0 to 59, SS: seconds from 0 to 59, ss: Hundreds of a second from 0 to 99.   
            Example: "00:14:45.86" means a time of 14:45.86. In addition the string "NT" is allowed if no time is available.

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
SwimTime in 100 of a secound.