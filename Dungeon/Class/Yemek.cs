using Dungeon.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.Class
{
    public abstract class Yemek : Esya
    {
        // Esyadan gelen ozellikler
        public string Adi { get; set; }
        public string Aciklama { get; set; }
        public int SatmaFiyati { get; set; }
        public int SatinAlmaFiyati { get; set; }

        // Kendi ozellikleri
        public int Doyurma { get; set; }
        public int Zehirleme { get; set; }
    }
}
