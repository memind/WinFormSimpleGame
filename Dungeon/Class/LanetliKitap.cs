using Dungeon.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.Class
{
    public abstract class LanetliKitap : Esya
    {
        // Esyadan gelen ozellikler
        public string Adi { get; set; }
        public string Aciklama { get; set; }
        public int SatmaFiyati { get; set; }
        public int SatinAlmaFiyati { get; set; }

        // Kendi Ozellikleri
        public int LanetDerecesi { get; set; } // Bu, ozellikleri arttirma orani

        public virtual void Lanetleme() { }

    }
}
