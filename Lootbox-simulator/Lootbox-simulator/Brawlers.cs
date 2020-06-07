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
        Random random = new Random();
        private List<string> epicBrawlers = new List<string>() { "Piper", "Pam", "Frank", "Bibi", "Bea", "Nani" };
        private List<string> myBrawlers = new List<string>();
        private bool isEmpty;
        private int count = 0;

        public void OpenBox()
        {
            //Console.Clear();

            count++;
            var chance = random.Next(1, 101);

            if(chance <= 5 && !isEmpty)
            {
                Epic();
            }
            else
            {
                Console.WriteLine("No reward from box " +count);
            }

        }
        public void Epic()
        {
            if (epicBrawlers.Count != 0)
            {
                var bIndex = random.Next(epicBrawlers.Count);
                var newBrawler = epicBrawlers[bIndex];

                Console.WriteLine("Unlocked Epic Brawler from box {0}: {1}" ,count, newBrawler);
                myBrawlers.Add(newBrawler);
                epicBrawlers.Remove(newBrawler);
                Console.WriteLine("Current Brawlers in list:");
                myBrawlers.ForEach(Console.WriteLine);
            }
            else
            {
                Console.WriteLine("All brawlers unlocked! :)");
                isEmpty = true;
            }
        }
    }
}
