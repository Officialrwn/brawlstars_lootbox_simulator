using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lootbox_simulator
{

    class Program
    {
        static void Main(string[] args)
        {
            var myAcc = new BoxTypes();

            Console.WriteLine("Press enter to get random brawler from list or type exit to stop program");
            var isTrue = true;
            do
            {
                var input = Console.ReadLine().ToLower();
                if (input != "exit")
                {
                    myAcc.Brawler();
                }
                else isTrue = false;
            } while (isTrue);
        }
    }
}