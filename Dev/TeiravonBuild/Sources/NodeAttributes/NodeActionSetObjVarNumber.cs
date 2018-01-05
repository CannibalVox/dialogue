using DialogueEditor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeiravonBuild
{
    class NodeActionSetObjVarNumber : NodeAction
    {
        [DisplayName("Object Var")]
        public string ObjVar { get; set; }
        public double Value { get; set; }

        public NodeActionSetObjVarNumber()
        {
            ObjVar = "Key";
        }

        public override string GetDisplayText()
        {
            return "[Set Object Var] [" + ObjVar + "=" + Value + "]";
        }
    }
}
