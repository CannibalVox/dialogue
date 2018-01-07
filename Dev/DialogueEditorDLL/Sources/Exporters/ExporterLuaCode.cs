using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogueEditor
{
    class ExporterLuaCode
    {
        private int indent = 0;
        private StringBuilder builder;
        bool requiresComma = false;

        public ExporterLuaCode(StringBuilder builder)
        {
            this.builder = builder;
        }

        public void WriteDialog(Dialogue dialog)
        {
            OpenBracket(string.Format("GeneratedDialog.{0}.{1}", dialog.PackageName, dialog.GetName()), "Dialogue");
            RenderObject(dialog);
            CloseClassBracket();
            builder.AppendLine();
        }

        private void OpenBracket(string key, string className = "")
        {
            WriteComma();
            builder.AppendLine();

            WriteIndent();
            WriteKey(key);

            if (!string.IsNullOrEmpty(className))
                builder.Append(className + "(");
            builder.Append("{");

            requiresComma = false;
            indent++;
        }

        private void OpenClassBracket(string key, object value)
        {
            string typeName, assemblyName;
            EditorCore.SerializationBinder.BindToName(value.GetType(), out assemblyName, out typeName);
            typeName = value.GetType().BaseType.Name + typeName;
            OpenBracket(key, typeName);
        }

        private void CloseBracket()
        {
            builder.AppendLine();
            indent--;

            if (indent < 0)
                throw new Exception("Unbalanced brackets!" + Environment.NewLine + builder.ToString());

            WriteIndent();
            builder.Append("}");
            requiresComma = true;
        }

        private void CloseClassBracket()
        {
            CloseBracket();
            builder.Append(")");
        }

        private void WriteKey(string key)
        {
            if (!string.IsNullOrEmpty(key))
                builder.AppendFormat("{0} = ", key);
        }

        private void WriteComma()
        {
            if (requiresComma)
                builder.Append(",");
        }

        private void WriteIndent()
        {
            for (int i = 0; i < indent; i++)
                builder.Append("    ");
        }

        private void WriteString(string key, string value)
        {
            WriteComma();
            builder.AppendLine();
            WriteIndent();

            WriteKey(key);
            builder.AppendFormat("\"{0}\"", value);
            requiresComma = true;
        }

        private void WriteNumber(string key, double number)
        {
            WriteComma();
            builder.AppendLine();
            WriteIndent();

            WriteKey(key);
            builder.AppendFormat("{0}", number);
            requiresComma = true;
        }

        private void WriteBool(string key, bool condition)
        {
            WriteComma();
            builder.AppendLine();
            WriteIndent();

            WriteKey(key);
            builder.AppendFormat("{0}", condition.ToString().ToLowerInvariant());
            requiresComma = true;
        }

        private void RenderObject(Dialogue dialog)
        {
            WriteString("Name", dialog.GetName());
            WriteNumber("RootNode", dialog.RootNodeID);
            OpenBracket("NodeList");

            var orderedListNodes = new List<DialogueNode>();
            dialog.GetOrderedNodes(ref orderedListNodes);
            RenderObject(orderedListNodes);

            CloseBracket();

            OpenBracket("IDToIndex");
            for (int i = 0; i < orderedListNodes.Count; i++)
            {
                WriteNumber("[" + orderedListNodes[i].ID + "]", i);
            }
            CloseBracket();
        }

        private void RenderObject(List<DialogueNode> nodes)
        {
            foreach (var node in nodes)
            {
                OpenBracket("", "DialogueNode");
                RenderObject(node);
                CloseClassBracket();
            }
        }

        private void RenderObject(DialogueNode node)
        {
            WriteNumber("ID", node.ID);
            WriteNumber("NextID", node.NextID);

            if (node is DialogueNodeGoto)
            {
                WriteNumber("GotoID", ((DialogueNodeGoto)node).GotoID);
            }

            if (node is DialogueNodeBranch)
            {
                WriteNumber("BranchID", ((DialogueNodeBranch)node).BranchID);
            }

            if (node is DialogueNodeChoice)
            {
                OpenBracket("ReplyIDs");
                foreach (var id in ((DialogueNodeChoice)node).RepliesIDs)
                {
                    WriteNumber("", id);
                }
                CloseBracket();
            }

            if (node is DialogueNodeSentence)
            {
                WriteString("Sentence", ((DialogueNodeSentence)node).Sentence);
            }

            if (node is DialogueNodeReply)
            {
                WriteString("Reply", ((DialogueNodeReply)node).Reply);
            }

            RenderAutoList("Conditions", node.Conditions.ToList<object>());
            RenderAutoList("Actions", node.Actions.ToList<object>());
            RenderAutoList("Flags", node.Flags.ToList<object>());
        }

        private void RenderAutoList(string key, List<object> objects)
        {
            OpenBracket(key);
            foreach(var obj in objects)
            {
                OpenClassBracket("",obj);
                AutoRender(obj);
                CloseClassBracket();
            }
            CloseBracket();
        }

        private void AutoRender(object obj)
        {
            foreach (var prop in obj.GetType().GetProperties())
            {
                if (!prop.CanRead || !prop.GetSetMethod(true).IsPublic)
                    continue;

                object objValue = prop.GetValue(obj);

                if (objValue.GetType().IsGenericType && objValue.GetType().GetGenericTypeDefinition() == typeof(List<>))
                {
                    RenderAutoList(prop.Name, ((IEnumerable)objValue).OfType<object>().ToList());
                    continue;
                }
                if (objValue is bool)
                {
                    WriteBool(prop.Name, (bool)objValue);
                    continue;
                }
                try
                {
                    double value = (double)Convert.ChangeType(objValue, typeof(double));
                    WriteNumber(prop.Name, value);
                }
                catch
                {
                    WriteString(prop.Name, objValue.ToString());
                }
            }
        }
    }
}
