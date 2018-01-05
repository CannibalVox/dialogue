using DialogueEditor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeiravonBuild
{
    class NodeConditionTimerTicking : NodeCondition
    {
        public string TimerName { get; set; }

        public NodeConditionTimerTicking()
        {
            TimerName = "SomeTimerName";
        }

        protected override string GetDisplayText_Impl()
        {
            return "[Is Timer Ticking] [" + TimerName + "]";
        }
    }
}
