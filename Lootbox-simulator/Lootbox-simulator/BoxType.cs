using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lootbox_simulator.Extensions;

namespace Lootbox_simulator
{
    public class BoxType
    {
        Random rand = new Random();
        Reward reward = new Reward();
        BrawlerCollection brawlList = new BrawlerCollection();
        List<string> bufferList = new List<string>();

        private const int MIN_POWER_POINTS = 10;
        private const int MAX_POWER_POINTS = 24;

        //DROP RATES:
        private const double RARE = 2.6928;

        /* Droprates: 
          Rare 2.6928
          Super Rare 1.2096
          Epic 0.5472
          Mythic 0.2496
          Legendary 0.1008
          Starpower 1.0
          */

        private double GetRandNumber(double minimum, double maximum)
        {
            return rand.NextDouble() * (maximum - minimum) + minimum;
        }

        private string GetRandElement(List<string> list)
        {
            return list[rand.Next(list.Count)];
        }

        public void Test(List<string> list)
        {
            var chance = Math.Round(GetRandNumber(0, 101),4);
            Console.WriteLine(chance);
            if (chance <= 40)
            {
                brawlList.CopyBrawlerList(bufferList, "Rare");
                var activeList = new List<string>();

                for (int i = 0; i < bufferList.Count; i++)
                {
                    if (!list.Contains(bufferList[i]) && !activeList.Contains(bufferList[i]))
                        activeList.Add(bufferList[i]);
                }

                if (!activeList.Any())
                    Console.WriteLine("Obtained all Rare brawlers!");
                else
                {
                    var b = GetRandElement(activeList);
                    list.Add(b);
                    activeList.Remove(b);
                }
            }
            else
                Console.WriteLine("No brawler");
        }

        private void PowerPoints(List<string> list, int j)
        {
            //To prevent powerpoints distribution to same brawler twice and iterate j depending on box type
            var bufferList = new List<string>(list);

            for (int i = 0; i < j; i++)
            {
                var rngBrawler = GetRandElement(bufferList);
                var powerPoint = rand.Next(MIN_POWER_POINTS, MAX_POWER_POINTS);

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
            var chance = Math.Round(GetRandNumber(0, 101), 4);
            Console.WriteLine(chance);
        }

        public void MegaBox()
        {
            //reward.Gold(rand.Next(100, 200));
            //PowerPoints(4);
            //Brawler();
        }

    }
}