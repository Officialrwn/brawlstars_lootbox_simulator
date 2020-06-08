using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lootbox_simulator
{
    public class Brawlers
    {
        private List<string> epicBrawlers = new List<string>() { "Piper", "Pam", "Frank", "Bibi", "Bea", "Nani" };
        public List<string> myBrawlers = new List<string>() { "Shelly", "Nita", "Colt", "Bull", "Jessie", "Brock" };
        public bool isEpic;
        public void Gold()
        {
            RandomGenerator.Rng(30, 250);
            Console.WriteLine("Gold reward: " +RandomGenerator.rngNum);
        }

        public void PowerPoints(List<string> list)
        {
            RandomGenerator.Rng(10, 50);
            RandomGenerator.RngIndex(list);
            list.Remove(RandomGenerator.rngBrawler);
            Console.WriteLine("{0} Powerpoints for {1}", RandomGenerator.rngNum, RandomGenerator.rngBrawler);
        }

        public void Epic()
        {
            if (epicBrawlers.Count != 0)
            {
                RandomGenerator.RngIndex(epicBrawlers);

                Console.WriteLine("******************************");
                Console.WriteLine("Unlocked Epic Brawler: {0}", RandomGenerator.rngBrawler);
                Console.WriteLine("******************************");
                myBrawlers.Add(RandomGenerator.rngBrawler);
                epicBrawlers.Remove(RandomGenerator.rngBrawler);
                Console.WriteLine();

                //Console.WriteLine("Current Brawlers in list:");
                //myBrawlers.ForEach(Console.WriteLine);
                //Console.WriteLine();
            }
            else
            {
                isEpic = true;
            }
        }
    }
}
