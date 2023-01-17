using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.Abstract
{
    public interface IDusman
    {
        public int Hasar { get; set; }
        void Saldir();
        void OzelSaldiri();
    }
}
