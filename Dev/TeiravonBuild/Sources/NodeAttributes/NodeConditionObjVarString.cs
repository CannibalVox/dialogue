using DialogueEditor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeiravonBuild
{
    class NodeConditionObjVarString : NodeCondition
    {
        [DisplayName("Object Var")]
        public string ObjVar { get; set; }
        public string Value { get; set; }

        public NodeConditionObjVarString()
        {
            ObjVar = "Key";
            Value = "...";
        }

        protected override string GetDisplayText_Impl()
        {
            return "[Object Var] [" + ObjVar + " == \"" + Value + "\"]";
        }
    }
}
