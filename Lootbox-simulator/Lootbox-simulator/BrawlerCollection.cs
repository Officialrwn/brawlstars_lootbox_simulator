using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lootbox_simulator.Extensions;


namespace Lootbox_simulator
{
    public class BrawlerCollection
    {
        private int Starter;
        private int Rare = 15;
        private int SuperRare = 10; 
        //private int Epic = 0.5472;
        //private int Mythic = 0.2496;
        //private int Legendary = 0.1008;

        public List<Brawlers> BrawlerList()
        {
            return new List<Brawlers>
            {
                new Brawlers() {Name = "Shelly", Tier = Starter},
                new Brawlers() {Name = "Nita", Tier = Starter},
                new Brawlers() {Name = "Colt", Tier = Starter},
                new Brawlers() {Name = "Bull", Tier = Starter},
                new Brawlers() {Name = "Jessie", Tier = Starter},
                new Brawlers() {Name = "Brock", Tier = Starter},

                new Brawlers() {Name = "El Primo Rare", Tier = Rare},
                new Brawlers() {Name = "Barley", Tier = Rare},
                new Brawlers() {Name = "Poco", Tier = Rare},
                new Brawlers() {Name = "Rosa", Tier = Rare},

                new Brawlers() {Name = "Rico Super Rare", Tier = SuperRare},
                new Brawlers() {Name = "Darryl", Tier = SuperRare},
                new Brawlers() {Name = "Penny", Tier = SuperRare},
                new Brawlers() {Name = "Carl", Tier = SuperRare},
                new Brawlers() {Name = "Jacky", Tier = SuperRare},
            };
        }

        public void GetStartBrawlers(List<string> strList)
        {
            BrawlerList()
                    .Where(x => x.Tier == Starter)
                    .ForEach(x => strList.Add(x.Name));
        }
    }
}
