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

        private readonly List<string> epicBrawlers = new List<string>()
        {
            "Piper", "Pam", "Frank", "Bibi", "Bea", "Nani"
        };

        public List<string> myBrawlers = new List<string>()
        {
            "Shelly", "Nita", "Colt", "Bull", "Jessie", "Brock"
        };

        private const int MIN_POWER_POINTS = 10;
        private const int MAX_POWER_POINTS = 24;
        private const double CHANCE_INCREMENTS_PERCENTAGE = 0.5;

        public double GetRandomNumber(double minimum, double maximum)
        {
            return rng.NextDouble() * (maximum - minimum) + minimum;
        }

        public string RngElement(List<string> list)
        {
            return list[rng.Next(list.Count)];
        }

        public void PowerPoints(int j)
        {
            //To prevent powerpoints distribution to same brawler twice and iterate j depending on box type
            List<string> bufferList = new List<string>(myBrawlers); 

            for (int i = 0; i < j; i++) 
            {
                var rngBrawler = RngElement(bufferList);
                var powerPoint = rng.Next(MIN_POWER_POINTS, MAX_POWER_POINTS);

                reward.PowerPoints(powerPoint, rngBrawler);
                bufferList.Remove(rngBrawler);
            }
        }

        public void Brawler()
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
     
        
        



        public void EpicBrawler()
        {
            //RandomGenerator.Rng(1, 101)
            //Console.WriteLine("6 rewards unlocked! Box nr: " + count++);
            //Console.WriteLine("Gold reward: " + reward.RngNum(30, 220));

            //if (RandomGenerator.rngNum <= epicProbability && !brawlbox.isEpic)
            //    brawlbox.Epic();
            //else
            //{
            //    brawlbox.PowerPoints(bufferList);
            //    epicProbability = Math.Min(epicProbability + increments, 100);
            //    Console.WriteLine("\nNo new brawler unlocked. Chance increased to: {0}%" ,epicProbability.ToString("0.0"));
            //    Console.WriteLine("-------------------------------------");
            //}


            //if (epicBrawlers.Count != 0)
            //{
            //    RandomGenerator.RngIndex(epicBrawlers);

            //    Console.WriteLine("******************************");
            //    Console.WriteLine("Unlocked Epic Brawler: {0}", RandomGenerator.rngBrawler);
            //    Console.WriteLine("******************************");
            //    myBrawlers.Add(RandomGenerator.rngBrawler);
            //    epicBrawlers.Remove(RandomGenerator.rngBrawler);
            //    Console.WriteLine();

            //    //Console.WriteLine("Current Brawlers in list:");
            //    //myBrawlers.ForEach(Console.WriteLine);
            //    //Console.WriteLine();
            //}
            //else
            //{
            //    isEpic = true;
            //}
        }
    }
}