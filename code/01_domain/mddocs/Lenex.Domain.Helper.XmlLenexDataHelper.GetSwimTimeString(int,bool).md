#### [Lenex.Domain](index.md 'index')
### [Lenex.Domain.Helper](Lenex.Domain.Helper.md 'Lenex.Domain.Helper').[XmlLenexDataHelper](Lenex.Domain.Helper.XmlLenexDataHelper.md 'Lenex.Domain.Helper.XmlLenexDataHelper')

## XmlLenexDataHelper.GetSwimTimeString(int, bool) Method

Get a SwimTime in the Lenex format

```csharp
public static string? GetSwimTimeString(int swimTime, bool NullString=true);
```
#### Parameters

<a name='Lenex.Domain.Helper.XmlLenexDataHelper.GetSwimTimeString(int,bool).swimTime'></a>

`swimTime` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

SwimTime in 100 of a secound.

<a name='Lenex.Domain.Helper.XmlLenexDataHelper.GetSwimTimeString(int,bool).NullString'></a>

`NullString` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

If true returns null, If false returns "NT"

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')