using System;
using System.Windows.Forms;

namespace RemotePlayTogetherEverything
{
    public partial class MainForm : Form
    {
        private readonly GamesManager gamesManager;
        public MainForm(GamesManager gamesManager)
        {
            InitializeComponent();

            this.gamesManager = gamesManager;
            UpdateList();

            toolStripGamesAdd.Click += ToolStripGamesAdd_Click;
            toolStripGamesItemAdd.Click += ToolStripGamesAdd_Click;
            toolStripGamesItemDelete.Click += ToolStripGamesItemDelete_Click;
            toolStripGamesItemEdit.Click += ToolStripGamesItemEdit_Click;
            toolStripGamesItemRun.Click += ToolStripGamesItemRun_Click;

            listBoxGames.MouseDown += ListBoxGames_MouseDown;
            listBoxGames.MouseDoubleClick += ListBoxGames_MouseDoubleClick;
        }

        private void ToolStripGamesItemRun_Click(object sender, EventArgs e)
        {
            StartGame(listBoxGames.SelectedIndex);
        }

        private void ToolStripGamesItemEdit_Click(object sender, EventArgs e)
        {
            var editGameForm = new EditGameForm(gamesManager.Games[listBoxGames.SelectedIndex]);
            if (editGameForm.ShowDialog() == DialogResult.OK)
            {
                gamesManager.UpdateGame(listBoxGames.SelectedIndex, editGameForm.Game);
                UpdateList();
            }
        }

        private void ToolStripGamesItemDelete_Click(object sender, EventArgs e)
        {
            gamesManager.DeleteGame(listBoxGames.SelectedIndex);
            UpdateList();
        }

        private void ListBoxGames_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var index = listBoxGames.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                StartGame(index);
            }
        }

        private void ToolStripGamesAdd_Click(object sender, EventArgs e)
        {
            var newGamesForm = new EditGameForm();
            if(newGamesForm.ShowDialog() == DialogResult.OK)
            {
                gamesManager.AddGame(newGamesForm.Game);
                UpdateList();
            }
        }

        private void ListBoxGames_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            var index = listBoxGames.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                listBoxGames.SelectedIndex = index;
                contextMenuStripGamesItem.Show(Cursor.Position);
            }
            else
            {
                contextMenuStripGames.Show(Cursor.Position);
            }
        }

        private void UpdateList()
        {
            listBoxGames.Items.Clear();
            foreach(var game in gamesManager.Games)
            {
                listBoxGames.Items.Add(game);
            }
        }

        private void StartGame(int index)
        {
            this.Hide();
            gamesManager.RunGame(index);
            this.Close();
        }

        private void ButtonPlay_Click(object sender, EventArgs e)
        {

        }
    }
}
