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
        private List<double> dblList = new List<double>();
        //private List<string> strList = new List<string>();

        //Brawler droprates
        public double Starter = 0;
        public double Rare = 50; // 2.6928;
        public double SuperRare = 30; //1.2096;
        //private double Epic = 0.5472;
        //private double Mythic = 0.2496;
        //private double Legendary = 0.1008;

        private bool RareIsEmpty = false;
        private bool SuperRareIsEmpty = false;
        //private bool EpicIsEmpty;
        //private bool MythicIsEmpty;
        //private bool LegendaryIsEmpty;


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

                new Brawlers() {Name = "El Primo Rare", Tier = Rare, IsEmpty = RareIsEmpty},
                new Brawlers() {Name = "Barley", Tier = Rare, IsEmpty = RareIsEmpty},
                new Brawlers() {Name = "Poco", Tier = Rare, IsEmpty = RareIsEmpty},
                new Brawlers() {Name = "Rosa", Tier = Rare, IsEmpty = RareIsEmpty},

                new Brawlers() {Name = "Rico Super Rare", Tier = SuperRare, IsEmpty = SuperRareIsEmpty},
                new Brawlers() {Name = "Darryl", Tier = SuperRare, IsEmpty = SuperRareIsEmpty},
                new Brawlers() {Name = "Penny", Tier = SuperRare, IsEmpty = SuperRareIsEmpty},
                new Brawlers() {Name = "Carl", Tier = SuperRare, IsEmpty = SuperRareIsEmpty},
                new Brawlers() {Name = "Jacky", Tier = SuperRare, IsEmpty = SuperRareIsEmpty},
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
