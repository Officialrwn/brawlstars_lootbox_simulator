using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lootbox_simulator
{
    public class Rewards
    {
        private Random rng = new Random();
        private List<string> epicBrawlers = new List<string>() { "Piper", "Pam", "Frank", "Bibi", "Bea", "Nani" };
        public List<string> myBrawlers = new List<string>() { "Shelly", "Nita", "Colt", "Bull", "Jessie", "Brock" };
        public bool isEpic;

        public int Gold(int a, int b)
        {
            return rng.Next(a, b);
        }

        public void PowerPoints(List<string> list)
        {
            var rngBrawler = list[rng.Next(list.Count)];
            Console.WriteLine("{0} Powerpoints for {1}", rng.Next(10, 50), rngBrawler);
            list.Remove(rngBrawler);
        }

        public void Epic()
        {
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
