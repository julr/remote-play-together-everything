
namespace RemotePlayTogetherEverything
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStripGamesItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripGamesItemRun = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripGamesItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripGamesItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripGamesItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripGames = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripGamesAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxGames = new System.Windows.Forms.ListBox();
            this.contextMenuStripGamesItem.SuspendLayout();
            this.contextMenuStripGames.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripGamesItem
            // 
            this.contextMenuStripGamesItem.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.contextMenuStripGamesItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripGamesItemRun,
            this.toolStripGamesItemEdit,
            this.toolStripGamesItemDelete,
            this.toolStripSeparator,
            this.toolStripGamesItemAdd});
            this.contextMenuStripGamesItem.Name = "contextMenuStrip1";
            this.contextMenuStripGamesItem.Size = new System.Drawing.Size(172, 186);
            // 
            // toolStripGamesItemRun
            // 
            this.toolStripGamesItemRun.Name = "toolStripGamesItemRun";
            this.toolStripGamesItemRun.Size = new System.Drawing.Size(171, 44);
            this.toolStripGamesItemRun.Text = "Run";
            // 
            // toolStripGamesItemEdit
            // 
            this.toolStripGamesItemEdit.Name = "toolStripGamesItemEdit";
            this.toolStripGamesItemEdit.Size = new System.Drawing.Size(171, 44);
            this.toolStripGamesItemEdit.Text = "Edit";
            // 
            // toolStripGamesItemDelete
            // 
            this.toolStripGamesItemDelete.Name = "toolStripGamesItemDelete";
            this.toolStripGamesItemDelete.Size = new System.Drawing.Size(171, 44);
            this.toolStripGamesItemDelete.Text = "Delete";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(168, 6);
            // 
            // toolStripGamesItemAdd
            // 
            this.toolStripGamesItemAdd.Name = "toolStripGamesItemAdd";
            this.toolStripGamesItemAdd.Size = new System.Drawing.Size(171, 44);
            this.toolStripGamesItemAdd.Text = "Add";
            // 
            // contextMenuStripGames
            // 
            this.contextMenuStripGames.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.contextMenuStripGames.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripGamesAdd});
            this.contextMenuStripGames.Name = "contextMenuStripGames";
            this.contextMenuStripGames.Size = new System.Drawing.Size(144, 48);
            // 
            // toolStripGamesAdd
            // 
            this.toolStripGamesAdd.Name = "toolStripGamesAdd";
            this.toolStripGamesAdd.Size = new System.Drawing.Size(143, 44);
            this.toolStripGamesAdd.Text = "Add";
            // 
            // listBoxGames
            // 
            this.listBoxGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxGames.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxGames.FormattingEnabled = true;
            this.listBoxGames.IntegralHeight = false;
            this.listBoxGames.ItemHeight = 48;
            this.listBoxGames.Location = new System.Drawing.Point(0, 0);
            this.listBoxGames.Margin = new System.Windows.Forms.Padding(5);
            this.listBoxGames.Name = "listBoxGames";
            this.listBoxGames.Size = new System.Drawing.Size(781, 498);
            this.listBoxGames.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 498);
            this.Controls.Add(this.listBoxGames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainForm";
            this.Text = "Remote Play Together Everything";
            this.contextMenuStripGamesItem.ResumeLayout(false);
            this.contextMenuStripGames.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStripGamesItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripGames;
        private System.Windows.Forms.ToolStripMenuItem toolStripGamesAdd;
        private System.Windows.Forms.ToolStripMenuItem toolStripGamesItemEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripGamesItemDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem toolStripGamesItemAdd;
        private System.Windows.Forms.ToolStripMenuItem toolStripGamesItemRun;
        private System.Windows.Forms.ListBox listBoxGames;
    }
}

