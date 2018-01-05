using DialogueEditor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeiravonBuild
{
    class TargetActionListConverter : PropertyCustomListConverter
    {
        public TargetActionListConverter()
        {
            CustomListName = "TargetActions";
        }
    }

    class NodeActionSendMessageToTarget : NodeAction
    {
        [TypeConverter(typeof(TargetActionListConverter))]
        public string MessageName { get; set; }

        public NodeActionSendMessageToTarget()
        {
            MessageName = "Flee";
        }

        public override string GetDisplayText()
        {
            string actionDisplay = "Unknown";
            EditorCore.CustomLists["TargetActions"].TryGetValue(MessageName, out actionDisplay);
            return "[SendMessageToTarget] [" + actionDisplay + "]";
        }
    }
}
