using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lootbox_simulator
{

    public class RandomGenerator
    {
        public static string rngBrawler;
        public static int rngNum;
        private static Random random = new Random();

        public static void Rng(int a, int b)
        {
            rngNum = random.Next(a, b);
        }
        
        /* Get random element from list */

        public static void RngIndex(List<string> list)
        {
            var IndexNum = random.Next(list.Count);
            rngBrawler = list[IndexNum];
        }

    }
}
