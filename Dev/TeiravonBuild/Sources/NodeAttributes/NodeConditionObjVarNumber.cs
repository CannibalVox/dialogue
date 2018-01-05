using DialogueEditor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeiravonBuild
{
    class NodeConditionObjVarNumber : NodeCondition
    {
        [DisplayName("Object Var")]
        public string ObjVar { get; set; }
        public double Value { get; set; }

        public NodeConditionObjVarNumber()
        {
            ObjVar = "Key";
            Value = 0;
        }

        protected override string GetDisplayText_Impl()
        {
            return "[Object Var] [" + ObjVar + " == " + Value + "]";
        }
    }
}
