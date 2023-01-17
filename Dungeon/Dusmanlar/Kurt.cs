using Dungeon.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.Dusmanlar
{
    internal class Kurt : Dusman
    {
        public string Ad = "Kurt";
        public int Can = 100;
        public int Hasar;

        public Kurt()
        {
            Saldir();
        }

        public void Saldir() 
        { 
            Random rnd = new Random();
            Hasar = rnd.Next(0, 21);
        }
    }
}
