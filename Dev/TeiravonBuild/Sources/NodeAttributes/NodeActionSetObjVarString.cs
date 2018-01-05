using DialogueEditor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeiravonBuild
{
    class NodeActionSetObjVarString : NodeAction
    {
        [DisplayName("Object Var")]
        public string ObjVar { get; set; }
        public string Value { get; set; }

        public NodeActionSetObjVarString()
        {
            ObjVar = "Key";
            Value = "";
        }

        public override string GetDisplayText()
        {
            return "[Set Object Var] [" + ObjVar + "=\"" + Value + "\"]";
        }
    }
}
