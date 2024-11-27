using System.IO;
using System.Text;

namespace Lenex.Handler.Serializer
{
    internal class StringWriterWithEncoding : StringWriter
    {
        public StringWriterWithEncoding(StringBuilder sb, Encoding encoding)
              : base(sb)
        {
            m_Encoding = encoding;
        }
        private readonly Encoding m_Encoding;
        public override Encoding Encoding
        {
            get
            {
                return m_Encoding;
            }
        }
    }
}
