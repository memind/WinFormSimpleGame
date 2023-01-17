using Dungeon.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.Concrete
{
    public abstract class Dusman : IDusman
    {
        public string Ad { get; set; }
        public int Can { get; set; }
        public int Hasar { get; set; }

        public void OzelSaldiri() { }

        public void Saldir() { }
    }
}
