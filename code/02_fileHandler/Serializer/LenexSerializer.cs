using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Dom = Lenex.Domain.Entities;

namespace Lenex.Handler.Serializer
{
    internal class LenexSerializer
    {
        internal static Task<string> SerializeLenexBody(Dom.Lenex LenexObj)
        {
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");

            XmlSerializer ser = new(typeof(Dom.Lenex));
            StringBuilder sb = new();
            StringWriterWithEncoding stringWriter = new StringWriterWithEncoding(sb, Encoding.UTF8);
            XmlWriterSettings xmlWriterSettings = new XmlWriterSettings
            {
                Encoding = Encoding.UTF8,
                NewLineHandling = NewLineHandling.Entitize,
                NewLineOnAttributes = false,
                Indent = true,
                OmitXmlDeclaration = false
            };
            using (XmlWriter stream = XmlWriter.Create(stringWriter, xmlWriterSettings))
            {
                stream.WriteStartDocument();
                ser.Serialize(stream, LenexObj, ns);
            }

            return Task.FromResult(sb.ToString());
        }
    }
}
