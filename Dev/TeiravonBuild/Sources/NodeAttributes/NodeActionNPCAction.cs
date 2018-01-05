using DialogueEditor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeiravonBuild
{
    class NodeActionNPCAction : NodeAction
    {
        [DisplayName("NPC Action Name")]
        public string Action { get; set; }

        public NodeActionNPCAction() {
            Action = "Interact";
        }

        public override string GetDisplayText()
        {
            return "[NPC Action] [" + Action + "]";
        }
    }
}
