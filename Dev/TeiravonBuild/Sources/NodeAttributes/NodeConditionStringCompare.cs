using DialogueEditor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeiravonBuild
{
    class NodeConditionStringCompare : NodeCondition
    {
        [DisplayName("Comparison Value")]
        public string ComparisonVal { get; set; }
        public string Value { get; set; }

        public NodeConditionStringCompare()
        {
            ComparisonVal = "Key";
            Value = "...";
        }

        protected override string GetDisplayText_Impl()
        {
            return "[Compare] [\"" + ComparisonVal + "\" == \"" + Value + "\"]";
        }
    }
}
