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
        BoxType open = new BoxType();
       
        public Account()
        {
            Brawlers.CopyBrawlerList(_myBrawlers, "Start");
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
            open.Test(_myBrawlers);
        }
    }
}
