using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lootbox_simulator
{
    public class BoxTypes
    {
        Rewards reward = new Rewards();

        private int count = 1;
        //private double epicProbability = 0.5;
        private const double increments = 0.5;

        public void Open()
        {
            List<string> bufferList = new List<string>(reward.myBrawlers);
            //RandomGenerator.Rng(1, 101)

            Console.WriteLine("6 rewards unlocked! Box nr: " + count++);
            Console.WriteLine("Gold reward: " +reward.Gold(30, 220));

            for(int i = 0; i < 4; i++)
            {
                reward.PowerPoints(bufferList);
            }

            //if (RandomGenerator.rngNum <= epicProbability && !brawlbox.isEpic)
            //    brawlbox.Epic();
            //else
            //{
            //    brawlbox.PowerPoints(bufferList);
            //    epicProbability = Math.Min(epicProbability + increments, 100);
            //    Console.WriteLine("\nNo new brawler unlocked. Chance increased to: {0}%" ,epicProbability.ToString("0.0"));
            //    Console.WriteLine("-------------------------------------");
            //}
        }
    }
}
