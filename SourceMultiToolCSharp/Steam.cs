using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceMultiToolCSharp
{
    public class Steam
    {
        public string MainSteamDir { get; set; }
        public List<string> AdditionalSteamDirectories { get => additionalSteamDirectories; set => additionalSteamDirectories = value; }

        private List<string> additionalSteamDirectories = new List<string>();
    }
}
