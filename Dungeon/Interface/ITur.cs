using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.Interface
{
    public interface ITur
    {
        public Tur Turu { get; set; }
        public int Dayaniklilik { get; set; }
        public int Guc { get; set; }
        public int Can { get; set; }
        public int Hiz { get; set; }
        public int Zeka { get; set; }
        public string TurYetenegi { get; set; }


        public enum Tur
        {
            Cuce = 1,
            Elf,
            Ork,
            Insan,
            Lanetli
        }
    }
}
