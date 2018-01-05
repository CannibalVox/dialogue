using DialogueEditor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeiravonBuild
{
    class NodeConditionHasUseCase : NodeCondition
    {
        public string UseCase { get; set; }

        public NodeConditionHasUseCase()
        {
            UseCase = "Interact";
        }

        protected override string GetDisplayText_Impl()
        {
            return "[Has Use Case] [" + UseCase + "]";
        }
    }
}
