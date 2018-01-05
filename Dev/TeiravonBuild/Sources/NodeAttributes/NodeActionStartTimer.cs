using DialogueEditor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeiravonBuild
{
    class NodeActionStartTimer : NodeAction
    {
        public string TimerName { get; set; }
        [DisplayName("Duration (ms)")]
        public int Duration { get; set; }

        public NodeActionStartTimer()
        {
            TimerName = "SomeTimerName";
            Duration = 1000;
        }

        public override string GetDisplayText()
        {
            return "[StartTimer] [" + TimerName + "] [" + Duration + "ms]";
        }
    }
}
