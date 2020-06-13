using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lootbox_simulator
{
    public class BrawlerCollection
    {
        private List<Brawlers> BrawlerList()
        {
            return new List<Brawlers>
            {
                new Brawlers() {Name = "Shelly", Tier = "Start"},
                new Brawlers() {Name = "Nita", Tier = "Start"},
                new Brawlers() {Name = "Colt", Tier = "Start"},
                new Brawlers() {Name = "Bull", Tier = "Start"},
                new Brawlers() {Name = "Jessie", Tier = "Start"},
                new Brawlers() {Name = "Brock", Tier = "Start"},

                new Brawlers() {Name = "Piper", Tier = "Rare"},
                new Brawlers() {Name = "Pam", Tier = "Rare"},
                new Brawlers() {Name = "Frank", Tier = "Rare"}
            };
        }

        public void CopyBrawlerList(List<string> list, string tier) // return brawler list based on tier
        {
           BrawlerList()
                .FindAll(b => b.Tier == tier)
                .ForEach((b) => list.Add(b.Name));
        }

        //var bufferList = new List<string>();

        //brawlList.GetBrawlerList("Start").ForEach((brawler) => bufferList.Add(brawler.Name));
    }
}
