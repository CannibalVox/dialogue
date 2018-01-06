using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogueEditor
{
    public partial class CodeExport : Form
    {
        //--------------------------------------------------------------------------------------------------------------
        // Public vars

        public List<Package> ListPackages = new List<Package>();

        public bool UseCustomSelection = false;
        public List<Dialogue> SelectedDialogues = new List<Dialogue>();

        public string ExportPath = "";

        //--------------------------------------------------------------------------------------------------------------
        // Class Methods

        public CodeExport(string title, string path)
        {
            InitializeComponent();

            Text = title;

            var project = ResourcesHandler.Project;

            checkedListBoxPackages.DataSource = new BindingSource(project.ListPackages, null);
            checkedListBoxPackages.DisplayMember = "Name";
            for (int i = 0; i < checkedListBoxPackages.Items.Count; ++i)
                checkedListBoxPackages.SetItemChecked(i, project.ListPackages[i].Export);

            checkBoxCustomSelection.Checked = UseCustomSelection;
            buttonChooseDialogues.Enabled = UseCustomSelection;

            ExportPath = path;
            textBoxPath.Text = ExportPath;
        }

        private void OnExportClick(object sender, EventArgs e)
        {
            ListPackages = checkedListBoxPackages.CheckedItems.Cast<Package>().ToList();

            UseCustomSelection = checkBoxCustomSelection.Checked;

            ExportPath = textBoxPath.Text;
        }

        private void OnEditPathClick(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Select the Aria mod directory :";

            dialog.SelectedPath = EditorHelper.GetProjectDirectory();
            if (Directory.Exists(textBoxPath.Text))
                dialog.SelectedPath = textBoxPath.Text;

            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string modPath = dialog.SelectedPath;
                if (!Directory.Exists(Path.Combine(modPath, "scripts", "globals", "static_data")))
                {
                    MessageBox.Show("Mod static data not found.");
                }
                else
                {
                    textBoxPath.Text = dialog.SelectedPath;
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void buttonChooseDialogues_Click(object sender, EventArgs e)
        {
            var project = ResourcesHandler.Project;
            string projectDirectory = EditorHelper.GetProjectDirectory();
            string exportDirectory = Path.Combine(projectDirectory, EditorCore.Settings.DirectoryExportDialogues);

            var dialog = new DialogDocumentSelector("Choose Dialogues..", SelectedDialogues);
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                return;
            }

            SelectedDialogues = dialog.checkedDialogues;
        }

        private void checkBoxCustomSelection_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxCustomSelection.Checked)
            {
                //Disable Packages list
                checkedListBoxPackages.SelectionMode = SelectionMode.None;
                checkedListBoxPackages.BackColor = Color.FromKnownColor(KnownColor.Control);

                //Enable Dialogue Selector
                buttonChooseDialogues.Enabled = true;
            }
            else
            {
                //Enable Packages list
                checkedListBoxPackages.SelectionMode = SelectionMode.One;
                checkedListBoxPackages.BackColor = Color.FromKnownColor(KnownColor.Window);

                //Disable Dialogue Selector
                buttonChooseDialogues.Enabled = false;
            }
        }
    }
}
