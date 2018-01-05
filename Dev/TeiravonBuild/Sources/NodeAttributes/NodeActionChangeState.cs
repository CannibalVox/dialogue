using DialogueEditor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeiravonBuild
{
    public class NodeActionChangeState : NodeAction
    {
        public string NewState { get; set; }

        public NodeActionChangeState()
        {
            NewState = "Alert";
        }

        public override string GetDisplayText()
        {
            return "[ChangeState] [" + NewState + "]";
        }
    }
}
