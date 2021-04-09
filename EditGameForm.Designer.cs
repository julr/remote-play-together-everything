
namespace RemotePlayTogetherEverything
{
    partial class EditGameForm
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelExe = new System.Windows.Forms.Label();
            this.labelExecPath = new System.Windows.Forms.Label();
            this.labelExecArgs = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxExe = new System.Windows.Forms.TextBox();
            this.textBoxExecArgs = new System.Windows.Forms.TextBox();
            this.textBoxExecPath = new System.Windows.Forms.TextBox();
            this.buttonExe = new System.Windows.Forms.Button();
            this.buttonExecPath = new System.Windows.Forms.Button();
            this.openFileDialogExe = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialogExecDir = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Controls.Add(this.buttonOk, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.labelName, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.labelExe, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.labelExecPath, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.labelExecArgs, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.textBoxName, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.textBoxExe, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.textBoxExecArgs, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.textBoxExecPath, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.buttonExe, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.buttonExecPath, 2, 3);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1027, 274);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel.SetColumnSpan(this.buttonOk, 3);
            this.buttonOk.Location = new System.Drawing.Point(429, 217);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(169, 52);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 6);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(88, 37);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // labelExe
            // 
            this.labelExe.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelExe.AutoSize = true;
            this.labelExe.Location = new System.Drawing.Point(3, 59);
            this.labelExe.Name = "labelExe";
            this.labelExe.Size = new System.Drawing.Size(153, 37);
            this.labelExe.TabIndex = 2;
            this.labelExe.Text = "Application";
            // 
            // labelExecPath
            // 
            this.labelExecPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelExecPath.AutoSize = true;
            this.labelExecPath.Location = new System.Drawing.Point(3, 166);
            this.labelExecPath.Name = "labelExecPath";
            this.labelExecPath.Size = new System.Drawing.Size(232, 37);
            this.labelExecPath.TabIndex = 3;
            this.labelExecPath.Text = "Working Directory";
            // 
            // labelExecArgs
            // 
            this.labelExecArgs.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelExecArgs.AutoSize = true;
            this.labelExecArgs.Location = new System.Drawing.Point(3, 113);
            this.labelExecArgs.Name = "labelExecArgs";
            this.labelExecArgs.Size = new System.Drawing.Size(146, 37);
            this.labelExecArgs.TabIndex = 4;
            this.labelExecArgs.Text = "Arguments";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(241, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(710, 43);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxExe
            // 
            this.textBoxExe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExe.Enabled = false;
            this.textBoxExe.Location = new System.Drawing.Point(241, 56);
            this.textBoxExe.Name = "textBoxExe";
            this.textBoxExe.Size = new System.Drawing.Size(710, 43);
            this.textBoxExe.TabIndex = 6;
            // 
            // textBoxExecArgs
            // 
            this.textBoxExecArgs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExecArgs.Location = new System.Drawing.Point(241, 110);
            this.textBoxExecArgs.Name = "textBoxExecArgs";
            this.textBoxExecArgs.Size = new System.Drawing.Size(710, 43);
            this.textBoxExecArgs.TabIndex = 7;
            // 
            // textBoxExecPath
            // 
            this.textBoxExecPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExecPath.Enabled = false;
            this.textBoxExecPath.Location = new System.Drawing.Point(241, 163);
            this.textBoxExecPath.Name = "textBoxExecPath";
            this.textBoxExecPath.Size = new System.Drawing.Size(710, 43);
            this.textBoxExecPath.TabIndex = 8;
            // 
            // buttonExe
            // 
            this.buttonExe.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonExe.Location = new System.Drawing.Point(957, 52);
            this.buttonExe.Name = "buttonExe";
            this.buttonExe.Size = new System.Drawing.Size(67, 52);
            this.buttonExe.TabIndex = 9;
            this.buttonExe.Text = "...";
            this.buttonExe.UseVisualStyleBackColor = true;
            this.buttonExe.Click += new System.EventHandler(this.ButtonExe_Click);
            // 
            // buttonExecPath
            // 
            this.buttonExecPath.Location = new System.Drawing.Point(957, 159);
            this.buttonExecPath.Name = "buttonExecPath";
            this.buttonExecPath.Size = new System.Drawing.Size(67, 52);
            this.buttonExecPath.TabIndex = 10;
            this.buttonExecPath.Text = "...";
            this.buttonExecPath.UseVisualStyleBackColor = true;
            this.buttonExecPath.Click += new System.EventHandler(this.ButtonExecPath_Click);
            // 
            // openFileDialogExe
            // 
            this.openFileDialogExe.DefaultExt = "exe";
            this.openFileDialogExe.Filter = "EXE|*.exe";
            // 
            // folderBrowserDialogExecDir
            // 
            this.folderBrowserDialogExecDir.Description = "Select Working Directory";
            this.folderBrowserDialogExecDir.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialogExecDir.ShowNewFolderButton = false;
            this.folderBrowserDialogExecDir.UseDescriptionForTitle = true;
            // 
            // EditGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 274);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "EditGameForm";
            this.Text = "EditGameForm";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelExe;
        private System.Windows.Forms.Label labelExecPath;
        private System.Windows.Forms.Label labelExecArgs;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxExe;
        private System.Windows.Forms.TextBox textBoxExecArgs;
        private System.Windows.Forms.TextBox textBoxExecPath;
        private System.Windows.Forms.Button buttonExe;
        private System.Windows.Forms.Button buttonExecPath;
        private System.Windows.Forms.OpenFileDialog openFileDialogExe;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogExecDir;
    }
}