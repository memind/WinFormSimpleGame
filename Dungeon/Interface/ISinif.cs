using Dungeon.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.Interface
{
    public interface ISinif
    {
        public Sinif Sinifi { get; set; }
        public Zirh Zirhi { get; set; }
        public Silah Silahi { get; set; }
        public Kalkan Kalkani { get; set; }

        public enum Sinif
        {
            Savasci,
            Sovalye,
            Suikastci,
            Okcu,
            Psisik,
            Buyucu,
            DogaDostu,
            KaranlikBuyucu,
            Asik
        }

        public enum Zirh
        {
            AgirZirh = 1,
            OrtaZirh,
            Cuppe
        }

        public enum Silah
        {
            UzunSilah = 1,
            KisaSilah,
            CiftHancer,
            OkYay,
            Asa,
            LanetliAsa,
            Telepati,
            Hepsi
        }

        public enum Kalkan
        {
            Yok,
            Var
        }
    }
}
