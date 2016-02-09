using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace DialogueCreator
{
    class Translator
    {
        private static Translator instance;

        public static Translator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Translator();
                }
                return instance;
            }
        }

        public void Write(List<Line> lines, string fileName)
        {
            if (!fileName.EndsWith(".xml"))
            {
                fileName += ".xml";
            }
            XmlTextWriter writer = new XmlTextWriter(fileName, System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("Lines");
            foreach (Line line in lines)
            {
                CreateLine(line, writer);
            }
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }

        public void Read(List<Line> lines, string fileName)
        {
            XDocument xml = XDocument.Load(fileName);      
            lines.Clear();

            var xElement1 = xml.Element("Lines");
            if (xElement1 != null)
                foreach (var xline in xElement1.Elements("Line"))
                {
                    lines.Add(new Line());
                    var xElement = xline.Element("Id");
                    if (xElement != null) lines.Last().Id = int.Parse(xElement.Value);
                    var element = xline.Element("Text");
                    if (element != null) lines.Last().SetText(element.Value);
                }

            if (xElement1 == null) return;
            {
                foreach (var xline in xElement1.Elements("Line"))
                {
                    var xElement = xline.Element("Empty");
                    if (xElement == null || !xElement.Value.Equals("False")) continue;
                    var element = xline.Element("Id");
                    if (element == null) continue;
                    var id = int.Parse(element.Value);
                    var element1 = xline.Element("Responses");
                    if (element1 == null) continue;
                    foreach (var xresponse in element1.Elements("Response"))
                    {
                        var line = lines.First(it => it.Id.Equals(id));
                        line.Responses.Add(new Response(line));
                        var o = xresponse.Element("Text");
                        if (o != null)
                            line.Responses.Last().SetText(o.Value);
                        line.Responses.Last().Next = lines.First(it => it.Id.Equals(int.Parse(xresponse.Element("Next_Id").Value)));
                    }
                }
            }
        }

        private void CreateLine(Line line, XmlTextWriter writer)
        {
            writer.WriteStartElement("Line");
            writer.WriteStartElement("Id");
            writer.WriteString(line.Id.ToString());
            writer.WriteEndElement();
            writer.WriteStartElement("Text");
            writer.WriteString(line.Text);
            writer.WriteEndElement();
            writer.WriteStartElement("Empty");
            if (line.Responses.Count.Equals(0))
            {
                writer.WriteString("True");
                writer.WriteEndElement();
            }
            else
            {
                writer.WriteString("False");
                writer.WriteEndElement();
                writer.WriteStartElement("Responses");

                foreach (Response resp in line.Responses)
                {
                    CreateResponse(resp, writer);
                }
                writer.WriteEndElement();
            }        
            writer.WriteEndElement();
        }

        private void CreateResponse(Response resp, XmlTextWriter writer)
        {
            writer.WriteStartElement("Response");
            writer.WriteStartElement("Text");
            writer.WriteString(resp.Text);
            writer.WriteEndElement();
            writer.WriteStartElement("Next_Id");
            writer.WriteString(resp.Next.Id.ToString());
            writer.WriteEndElement();
            writer.WriteEndElement();
        }
    }
}
