using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemotePlayTogetherEverything
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            GamesManager gamesManager = new GamesManager();

            string[] arguments = Environment.GetCommandLineArgs();
            if(arguments.Length > 1)
            {
                int index;
                if (int.TryParse(arguments[1], out index))
                {
                    if(index < gamesManager.Games.Count)
                    {
                        gamesManager.RunGame(index);
                    }
                    else
                    {
                        MessageBox.Show($"Invalid index \"{index}\"", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    string searchName = string.Join(' ', arguments.Skip(1));
                    bool found = false;
                    foreach(var game in gamesManager.Games)
                    {
                        if (game.Name == searchName)
                        {
                            gamesManager.RunGame(game);
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        MessageBox.Show($"Game \"{arguments[1]}\" not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                Application.Run(new MainForm(gamesManager));
            }
        }
    }
}
