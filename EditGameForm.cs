using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace RemotePlayTogetherEverything
{
    public partial class EditGameForm : Form
    {
        public GameInfo Game { get; private set; }
        public EditGameForm(GameInfo game = null)
        {
            InitializeComponent();

            if(game == null)
            {
                this.Text = "New Game";
                Game = new GameInfo();
            }
            else
            {
                this.Text = "Edit Game";
                
                textBoxName.Text = game.Name;
                textBoxExe.Text = game.Executatble;
                textBoxExecArgs.Text = game.Arguments;
                textBoxExecPath.Text = game.WorkingDirectory;

                Game = game;
            }
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            Game.Name = textBoxName.Text;
            Game.Executatble = textBoxExe.Text;
            Game.Arguments = textBoxExecArgs.Text;
            Game.WorkingDirectory = textBoxExecPath.Text;

            //Sanity check
            if(string.IsNullOrWhiteSpace(Game.Name))
            {
                MessageBox.Show("Name must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(Game.Executatble))
            {
                MessageBox.Show("Application must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void ButtonExe_Click(object sender, EventArgs e)
        {
            if(openFileDialogExe.ShowDialog() == DialogResult.OK)
            {
                textBoxExe.Text = openFileDialogExe.FileName;
                textBoxExecPath.Text = Path.GetDirectoryName(openFileDialogExe.FileName);
            }
        }

        private void ButtonExecPath_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialogExecDir.ShowDialog() == DialogResult.OK)
            {
                textBoxExecPath.Text = folderBrowserDialogExecDir.SelectedPath;
            }
        }
    }
}
