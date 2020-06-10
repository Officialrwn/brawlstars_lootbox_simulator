using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lootbox_simulator
{
    public class BoxTypes
    {
        Random rng = new Random();
        Rewards reward = new Rewards();
        BrawlerCollection brawlList = new BrawlerCollection();

        private const int MIN_POWER_POINTS = 10;
        private const int MAX_POWER_POINTS = 24;
        private const double CHANCE_INCREMENTS_PERCENTAGE = 0.5;

        public void Test()
        {
            var newList = new List<string>(brawlList.StartBrawlers);
            foreach (var b in newList)
            {
                Console.WriteLine(b);
            }
        }

        private double GetRandomNumber(double minimum, double maximum)
        {
            return rng.NextDouble() * (maximum - minimum) + minimum;
        }

        private string RngElement(List<string> list)
        {
            return list[rng.Next(list.Count)];
        }

        private void PowerPoints(int j)
        {
            //To prevent powerpoints distribution to same brawler twice and iterate j depending on box type
            var bufferList = new List<string>(brawlList.StartBrawlers); 

            for (int i = 0; i < j; i++) 
            {
                var rngBrawler = RngElement(bufferList);
                var powerPoint = rng.Next(MIN_POWER_POINTS, MAX_POWER_POINTS);

                reward.PowerPoints(powerPoint, rngBrawler);
                bufferList.Remove(rngBrawler);
            }
        }

        private void Brawler()
        {
            /* Droprates: 
            Rare 2.6928
            Super Rare 1.2096
            Epic 0.5472
            Mythic 0.2496
            Legendary 0.1008
            Starpower 1.0
            */
            var chance = Math.Round(GetRandomNumber(0, 101),4);
            Console.WriteLine(chance);
        }

        public void MegaBox()
        {
            reward.Gold(rng.Next(100, 200));
            PowerPoints(4);
            Brawler();
        }
    }
}