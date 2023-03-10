using Dungeon.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.Class
{
    public abstract class AgirZirh : Zirh
    {
        // Esyadan gelen ozellikler
        public string Adi { get; set; }
        public string Aciklama { get; set; }
        public int SatmaFiyati { get; set; }
        public int SatinAlmaFiyati { get; set; }

        // Zirhtan gelen ozellikleri
        public ISinif.Zirh Tipi { get; set; }
        public int ZirhMiktari { get; set; }

    }
}
