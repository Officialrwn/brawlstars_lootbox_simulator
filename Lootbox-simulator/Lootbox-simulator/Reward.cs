using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lootbox_simulator
{
    public class Reward
    {
        private int count = 1;

        public void Gold(int a)
        {
            Console.WriteLine("6 rewards unlocked! Box nr: " + count++);
            Console.WriteLine("Gold reward: " + a);
        }

        public void PowerPoints(int a, string brawler)
        {
            Console.WriteLine("{0} Powerpoints for {1}",a, brawler);
        }

        public void Brawler(string tier, string brawler)
        {
            Console.WriteLine("******************************");
            Console.WriteLine("Unlocked {0} Brawler: {1}",tier, brawler);
            Console.WriteLine("******************************");
            
        }
    }
}