﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DialogueCreator
{
    public class Line
    {
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

        private bool toDelete = false;
        private string name = "";
        private string text = "";
        private List<Response> responses = new List<Response>(); 

        public bool IsComplete()
        {
            SetName();
            if (responses.Count.Equals(0))
            {
                name = "(!) " + name;
                return false;
            }
            foreach (Response resp in responses)
            {
                if (!resp.isLinked())
                {
                    name = "(!) " + name; 
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