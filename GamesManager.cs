using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.Json;

namespace RemotePlayTogetherEverything
{
    public class GamesManager
    {
        private List<GameInfo> games;
        public IList<GameInfo> Games { get; private set; }

        private readonly string gamesFile;

        public GamesManager(string file = "Games.json")
        {
            games = new List<GameInfo>();
            Games = games.AsReadOnly();
            gamesFile = file;
            LoadGames();
        }

        public void AddGame(GameInfo game)
        {
            games.Add(game);
            SaveGames();
        }

        public void DeleteGame(int index)
        {
            games.RemoveAt(index);
            SaveGames();
        }

        public void UpdateGame(int index, GameInfo game)
        {
            games[index] = game;
            SaveGames();
        }

        public void RunGame(int index)
        {
            RunGame(games[index]);
        }

        public void RunGame(GameInfo game)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(game.Executatble);
            startInfo.Arguments = game.Arguments;
            startInfo.WorkingDirectory = game.WorkingDirectory;
            Process.Start(startInfo);
        }

        private void LoadGames()
        {
            if (File.Exists(gamesFile))
            {
                using (StreamReader reader = new StreamReader(gamesFile, Encoding.UTF8))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        games.Add(JsonSerializer.Deserialize<GameInfo>(line));
                    }
                }
            }
        }

        private void SaveGames()
        {
            using (StreamWriter writer = new StreamWriter(gamesFile, false, Encoding.UTF8))
            {
                foreach (var game in games)
                {
                    writer.WriteLine(JsonSerializer.Serialize<GameInfo>(game));
                }
            }
        }
    }
}
