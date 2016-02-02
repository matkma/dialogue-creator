using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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
                createLine(line, writer);
            }
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }

        private void createLine(Line line, XmlTextWriter writer)
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
                    createResponse(resp, writer);
                }
                writer.WriteEndElement();
            }        
            writer.WriteEndElement();
        }

        private void createResponse(Response resp, XmlTextWriter writer)
        {
            writer.WriteStartElement("Response");
            writer.WriteStartElement("Text");
            writer.WriteString(resp.Text);
            writer.WriteEndElement();
            writer.WriteStartElement("Previous_Id");
            writer.WriteString(resp.Previous.Id.ToString());
            writer.WriteEndElement();
            writer.WriteStartElement("Next_Id");
            writer.WriteString(resp.Next.Id.ToString());
            writer.WriteEndElement();
            writer.WriteEndElement();
        }
    }
}
