using DialogueEditor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeiravonBuild
{
    class NodeActionSay : NodeAction
    {
        public string SayText { get; set; }

        public NodeActionSay()
        {
            SayText = "...";
        }

        public override string GetDisplayText()
        {
            string text = SayText;
            if (SayText.Length > 25)
            {
                text = SayText.Substring(0, 22) + "...";
            }

            return "[Say] [" + text + "]";
        }
    }
}
