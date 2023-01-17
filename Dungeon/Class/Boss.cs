using Dungeon.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.Class
{
    public abstract class Boss : IBoss
    {
        public string Ad { get; set; }
        public int Can { get; set; }
        public int Hasar { get; set; }

        public void OzelGuc()
        {
            throw new NotImplementedException();
        }
    }
}
