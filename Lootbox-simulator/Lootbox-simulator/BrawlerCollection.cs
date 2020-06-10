using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lootbox_simulator
{
    public class BrawlerCollection
    {
        public IReadOnlyCollection<string> StartBrawlers => startBrawlers.AsReadOnly();
        public IReadOnlyCollection<string> EpicBrawler => epicBrawlers.AsReadOnly();

        private List<string> startBrawlers = new List<string>()
        {
            "Shelly", "Nita", "Colt", "Bull", "Jessie", "Brock"
        };

        private List<string> epicBrawlers = new List<string>()
        {
            "Piper", "Pam", "Frank", "Bibi", "Bea", "Nani"
        };

    }
}
