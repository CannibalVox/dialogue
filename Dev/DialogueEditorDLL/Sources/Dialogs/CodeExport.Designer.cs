namespace DialogueEditor
{
    partial class CodeExport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Button button1;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Button button2;
            System.Windows.Forms.Button button3;
            this.checkedListBoxPackages = new System.Windows.Forms.CheckedListBox();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonChooseDialogues = new System.Windows.Forms.Button();
            this.checkBoxCustomSelection = new System.Windows.Forms.CheckBox();
            label1 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(93, 13);
            label1.TabIndex = 2;
            label1.Text = "Select packages :";
            // 
            // button1
            // 
            button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            button1.Location = new System.Drawing.Point(364, 125);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Edit...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(this.OnEditPathClick);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 111);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(59, 13);
            label4.TabIndex = 9;
            label4.Text = "Mod Path :";
            // 
            // button2
            // 
            button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            button2.Location = new System.Drawing.Point(364, 161);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            button3.DialogResult = System.Windows.Forms.DialogResult.OK;
            button3.Location = new System.Drawing.Point(282, 161);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(75, 23);
            button3.TabIndex = 11;
            button3.Text = "Export";
            button3.UseVisualStyleBackColor = true;
            button3.Click += new System.EventHandler(this.OnExportClick);
            // 
            // checkedListBoxPackages
            // 
            this.checkedListBoxPackages.CheckOnClick = true;
            this.checkedListBoxPackages.FormattingEnabled = true;
            this.checkedListBoxPackages.Location = new System.Drawing.Point(12, 25);
            this.checkedListBoxPackages.Name = "checkedListBoxPackages";
            this.checkedListBoxPackages.Size = new System.Drawing.Size(143, 79);
            this.checkedListBoxPackages.TabIndex = 1;
            // 
            // textBoxPath
            // 
            this.textBoxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPath.Location = new System.Drawing.Point(12, 127);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(346, 20);
            this.textBoxPath.TabIndex = 5;
            // 
            // buttonChooseDialogues
            // 
            this.buttonChooseDialogues.Location = new System.Drawing.Point(161, 48);
            this.buttonChooseDialogues.Name = "buttonChooseDialogues";
            this.buttonChooseDialogues.Size = new System.Drawing.Size(99, 23);
            this.buttonChooseDialogues.TabIndex = 19;
            this.buttonChooseDialogues.Text = "Choose dialogues";
            this.buttonChooseDialogues.UseVisualStyleBackColor = true;
            this.buttonChooseDialogues.Click += new System.EventHandler(this.buttonChooseDialogues_Click);
            // 
            // checkBoxCustomSelection
            // 
            this.checkBoxCustomSelection.AutoSize = true;
            this.checkBoxCustomSelection.Location = new System.Drawing.Point(161, 25);
            this.checkBoxCustomSelection.Name = "checkBoxCustomSelection";
            this.checkBoxCustomSelection.Size = new System.Drawing.Size(108, 17);
            this.checkBoxCustomSelection.TabIndex = 20;
            this.checkBoxCustomSelection.Text = "Custom Selection";
            this.checkBoxCustomSelection.UseVisualStyleBackColor = true;
            this.checkBoxCustomSelection.CheckedChanged += new System.EventHandler(this.checkBoxCustomSelection_CheckedChanged);
            // 
            // CodeExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 196);
            this.ControlBox = false;
            this.Controls.Add(this.checkBoxCustomSelection);
            this.Controls.Add(this.buttonChooseDialogues);
            this.Controls.Add(button3);
            this.Controls.Add(button2);
            this.Controls.Add(label4);
            this.Controls.Add(button1);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(label1);
            this.Controls.Add(this.checkedListBoxPackages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CodeExport";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Export Aria Code";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxPackages;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonChooseDialogues;
        private System.Windows.Forms.CheckBox checkBoxCustomSelection;
    }
}