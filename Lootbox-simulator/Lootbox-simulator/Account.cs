using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;


namespace Lootbox_simulator
{
    public class Account
    {
        BrawlerCollection Brawlers = new BrawlerCollection();
        List<string> _myBrawlers = new List<string>();
        Box open = new Box();
 
        public Account()
        {
            Brawlers.GetStartBrawlers(_myBrawlers);
        }

        public ReadOnlyCollection<string> MyBrawlers
        {
            get
            {
                return _myBrawlers.AsReadOnly();
            }
        }

        public void OpenBox()
        {
            open.MegaBox(_myBrawlers);
        }
    }
}
