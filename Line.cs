using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DialogueCreator
{
    public class Line
    {
        static int linesCounter = 0;

        public List<Response> Responses
        {
            get
            {
                return responses;
            }

            set
            {
                responses = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public bool ToDelete
        {
            get
            {
                return toDelete;
            }

            set
            {
                toDelete = value;
            }
        }
        public string Text
        {
            get
            {
                return text;
            }
        }
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        private int id;
        private bool toDelete = false;
        private string name = "";
        private string text = "";
        private List<Response> responses = new List<Response>();

        private Random random = new Random();

        public Line()
        {
            linesCounter += 1;
            Id = int.Parse(random.Next(100, 999).ToString() + "0" + linesCounter.ToString());
        }

        ~Line()
        {
            linesCounter -= 1;
        }

        public bool IsComplete()
        {
            foreach (Response resp in responses)
            {
                if (!resp.isLinked())
                {
                    return false;
                }
            } 
            return true;
        }

        public void CreateResponse()
        {
            responses.Add(new Response(this));
        }

        public void RemoveResponse()
        {
            
        }

        public void LinkResponse()
        {
            
        }

        public void SetName()
        {
            if (Text.Length > 30)
            {
                name = Text.Remove(29);
            }
            else if (Text.Length == 0)
            {
                name = "EMPTY";
            }
            else
            {
                name = Text;
            }
        }

        public void SetText(string txt)
        {
            text = txt;
            SetName();
        }
    }
}
