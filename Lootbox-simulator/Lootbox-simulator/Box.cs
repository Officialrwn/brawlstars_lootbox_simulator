using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lootbox_simulator.Extensions;

namespace Lootbox_simulator
{
    public class Box
    {
        Random rand = new Random();
        BrawlerCollection brawlCollection = new BrawlerCollection();
        List<Brawlers> BrawlerList = new List<Brawlers>();
        List<string> bufferList = new List<string>();

        public Box()
        {
            BrawlerList = new List<Brawlers>(brawlCollection.BrawlerList());
        }

        private double GetMaxTier()
        {
            return BrawlerList.Select(m => m.Tier).Max();
        }

        private double GetRandNumber(double minimum, double maximum)
        {
            return rand.NextDouble() * (maximum - minimum) + minimum;
        }

        private string GetRandBrawler(List<string> list)
        {
            return list[rand.Next(list.Count)];
        }
      
        private void GetTierList(double dblNum, List<string> list) // Get closest Tier
        {
            var tier = BrawlerList
                .OrderBy(n => n.Tier).First(n => n.Tier > dblNum).Tier; 

            BrawlerList
                    .Where(x => x.Tier == tier)
                    .ForEach(x =>
                    {
                        if (!bufferList.Contains(x.Name) && !list.Contains(x.Name))
                            bufferList.Add(x.Name);
                    });
        }

        public void MegaBox(List<string> list)
        {
            //var randNum = Math.Round(GetRandNumber(0, 101), 4);
            var randNum = 45;
            var maxTier = GetMaxTier();

            Console.WriteLine("Random number: " + randNum);

            if (randNum > maxTier) //if probability is greater than brawler rewards then give powerpoints else get list of rewards from tier
                Console.WriteLine("Distributing a random amount of PowerPoints randomly to one of my brawlers...");
            else
                GetTierList(randNum, list);


            //Checking the reward list based on probability
            var randBrawler = GetRandBrawler(bufferList);

            Console.WriteLine("\nTier list: \n");
            bufferList.ForEach(brawler => Console.WriteLine(brawler));

        }
    }
}