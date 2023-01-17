using Dungeon.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.Class
{
    public abstract class Asa : Silah
    {
        // Esyadan gelen ozellikler
        public string Adi { get; set; }
        public string Aciklama { get; set; }
        public int SatmaFiyati { get; set; }
        public int SatinAlmaFiyati { get; set; }

        // Silahtan gelen ozellikleri
        public ISinif.Silah SilahTipi { get; set; }

        // Kendi Ozellikleri
        public int Hasar { get; set; }
        public int TuketecegiMana { get; set; }
    }
}
