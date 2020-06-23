using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lootbox_simulator.Extensions;

namespace Lootbox_simulator
{
    public class RewardCollection
    {
        BrawlerCollection brawlCollection = new BrawlerCollection();
        List<Brawlers> BrawlerList = new List<Brawlers>();
        Random rand = new Random();

        List<string> bufferList = new List<string>();
        List<string> myBrawlers = new List<string>();

        private int randNum;
        private int tier;
        private int maxTier;

        public RewardCollection()
        {
            BrawlerList = new List<Brawlers>(brawlCollection.BrawlerList());
            maxTier = MaxTier();
        }

        public void MegaBox(List<string> list)
        {
            myBrawlers = list;
            GoldReward();

            for (int i = 0; i < 4; i++)
            {
                randNum = rand.Next(0, 101);
                Console.Write(randNum + "%: ");

                if (randNum > maxTier)
                    DistributePowerPoints();
                else
                {
                    tier = GetTier(randNum);
                    GetBrawlerList(tier);
                    GetBrawler();
                }
            }
        }

        private int MaxTier()
        {
            return BrawlerList.Select(m => m.Tier).Max();
        }

        private int GetTier(int num)
        {
            return BrawlerList
                .Select(o => o.Tier)
                .Distinct().OrderBy(t => t)
                .First(n => n >= num);
        }

        private string GetRandBrawler(List<string> list)
        {
            return list[rand.Next(list.Count)];
        }
      
        private void GetBrawlerList(int num) // Get closest Tier
        {
            BrawlerList
                    .Where(x => x.Tier == num)
                    .ForEach(x =>
                    {
                        if (!bufferList.Contains(x.Name) && !myBrawlers.Contains(x.Name))
                            bufferList.Add(x.Name);
                    });
        }

        private void GoldReward()
        {
            Console.WriteLine("Gold reward: " + rand.Next(120,190));
        }

        private void DistributePowerPoints()
        {
            // Code to distribute random powerpoints to random brawler...
            Console.WriteLine("PowerPoints distributed to random brawler");
        }

        private void AddBrawler()
        {
            var randBrawler = GetRandBrawler(bufferList);

            myBrawlers.Add(randBrawler);
            bufferList.Remove(randBrawler);

            Console.WriteLine("Unlocked new brawler: " + randBrawler);
        }

        private void GetBrawler()
        {
            if (bufferList.Any())
            {
                AddBrawler();
            }
            else if (tier != maxTier)
            {
                var nextTier = GetTier(tier + 1);
                GetBrawlerList(nextTier);

                if (bufferList.Any())
                    AddBrawler();
                else
                    DistributePowerPoints();
            }
            else
                DistributePowerPoints();
        }
    }
}