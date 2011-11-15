using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;
using micautLib;

namespace InputPanelPlus
{
    public static class Util
    {
        public static string MathMlToLatex(string xml)
        {
            var transform = new XslCompiledTransform();
            transform.Load(typeof(mmltex));

            var sr = new StringReader(xml);
            var xmlReader = XmlReader.Create(sr);

            var sw = new StringWriter();
            var writer = new XmlTextWriter(sw);
            transform.Transform(xmlReader, null, writer);
            writer.Close();
            string latex = sw.ToString();

            return latex;
        }

        public static string GetMathMlFromClipboard()
        {
            var ido = Clipboard.GetDataObject();
            var data = (MemoryStream)ido.GetData("MathML");

            if (data == null)
                return null;

            string xml;
            using (data)
            using (var sr = new StreamReader(data))
                xml = sr.ReadToEnd();

            return xml;
        }

        public static string PrintXml(string xml)
        {
            var doc = new XmlDocument();
            doc.Load(xml);

            var textWriter = new StringWriter();
            var encoding = Encoding.UTF8;

            var xmlSettings =
                new XmlWriterSettings {
                  Encoding = encoding,
                  Indent = true,
            };

            var xmlWriter = XmlWriter.Create(textWriter, xmlSettings);

            doc.Save(xmlWriter);

            return textWriter.ToString();
        }
    }
}