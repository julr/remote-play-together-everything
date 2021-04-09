using System;
using System.Collections.Generic;
using System.Text;

namespace RemotePlayTogetherEverything
{
    public class GameInfo
    {
        public string Name { get; set; }
        public string Executatble { get; set; }
        public string WorkingDirectory { get; set; }
        public string Arguments { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
