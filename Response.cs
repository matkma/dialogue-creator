using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogueCreator
{
    public class Response
    {
        private bool toDelete = false;
        private Line previous;
        private Line next = null;
        private string text = "";
        private string name = "";

        public Line Previous
        {
            get
            {
                return previous;
            }

            set
            {
                previous = value;
            }
        }
        public Line Next
        {
            get
            {
                return next;
            }

            set
            {
                next = value;
            }
        }
        public string Text
        {
            get
            {
                return text;
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

        public Response(Line prev)
        {
            previous = prev;
        }

        public bool isLinked()
        {
            if (next != null && previous != null)
            {
                return true;
            }

            return false;
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
