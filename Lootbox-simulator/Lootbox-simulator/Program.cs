using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lootbox_simulator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // Create seperate class for user accounts (make user account create new list thats only readable with  starter brawlers).
          

            var myAcc = new Account();

            Console.WriteLine("Press enter to get random brawler from list or type exit to stop program");
            var isRunning = true;
            do
            {
                var input = Console.ReadLine().ToLower();
                if (input != "exit")
                {
                    myAcc.OpenBox();
                    new List<string>(myAcc.MyBrawlers).ForEach(b => Console.WriteLine(b));
                }
                else isRunning = false;
            } while (isRunning);
        }
    }
}