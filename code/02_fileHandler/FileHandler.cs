using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Lenex.Handler
{

    public class FileHandler : Domain.Interfaces.ILenexFileHandler
    {
        public string GetLenexFileName(Domain.Entities.Lenex LenexObj)
        {
            throw new NotImplementedException();
        }

        public Task<Domain.Entities.Lenex?> ReadLenexString(string LenexDataString)
        {
            XmlSerializer ser;
            ser = new XmlSerializer(typeof(Domain.Entities.Lenex));
            StringReader stringReader;
            stringReader = new StringReader(LenexDataString);
            XmlTextReader xmlReader;
            xmlReader = new XmlTextReader(stringReader);
            Domain.Entities.Lenex? obj;
            obj = (Domain.Entities.Lenex?)ser.Deserialize(xmlReader);
            xmlReader.Close();
            stringReader.Close();
            return Task.FromResult(obj);
        }

        public Task<string> GetLenexFileString(Domain.Entities.Lenex LenexObj)
        {
            try
            {
                return Serializer.LenexSerializer.SerializeLenexBody(LenexObj);
            }
            catch (Exception _ex)
            {
                Debug.WriteLine(_ex.Message);
                throw;
            }
        }

        public async Task WriteLenexFile(Domain.Entities.Lenex LenexObj, string outputPath, string fileName)
        {
#if NETSTANDARD2_1 || NET6_0
            await File.WriteAllTextAsync($"{outputPath}{Path.DirectorySeparatorChar}{fileName}", await GetLenexFileString(LenexObj));
#else
            File.WriteAllText($"{outputPath}{Path.DirectorySeparatorChar}{fileName}", await GetLenexFileString(LenexObj));
#endif
        }



        public Task<Domain.Entities.Lenex> ReadLenexFile(string LenexFileName)
        {
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(Domain.Entities.Lenex));
                Domain.Entities.Lenex? lenexData;
                using XmlReader reader = XmlReader.Create(LenexFileName);
                lenexData = (Domain.Entities.Lenex)ser.Deserialize(reader)!;
                return Task.FromResult(lenexData);
            }
            catch (Exception _ex)
            {
                Debug.WriteLine(_ex);
                throw;
            }
        }
    }
}
