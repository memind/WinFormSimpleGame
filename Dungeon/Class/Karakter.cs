using Dungeon.Class;
using Dungeon.Interface;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dungeon.Interface.ISinif;
using static Dungeon.Interface.ITur;

namespace Dungeon.Concrete
{
    public enum Bolgeler
    {
        Sehir1,
        Sehir2,
        Sehir3,
        Orman1,
        Orman2,
        KaleKalintisi
    }
    public class Karakter : ITur, ISinif
    {
        // Karakterin kendi ozellikleri
        public string Adi { get; set; }
        public int TecrubePuani { get; set; } = 0;
        public byte ZehirlenmeDurumu { get; set; }
        public int Altin { get; set; }
        public int CantaKapasitesi { get; set; }
        public List<Esya> Canta { get; set; }
        public List<BossEsya> BossEsyalar { get; set; }
        public byte AclikDurumu { get; set; } = 100;
        public int CanDurumu { get; set; }
        public int DayaniklilikDurumu { get; set; }

        // Turden gelen ozelliker
        
        private Tur _Turu;
        public Tur Turu
        {
            get { return _Turu; }
            set 
            {
                if (value.ToString() == "Cuce")
                    _Turu = (Tur)1;
                if (value.ToString() == "Elf")
                    _Turu = (Tur)2;
                if (value.ToString() == "Ork")
                    _Turu = (Tur)3;
                if (value.ToString() == "Insan")
                    _Turu = (Tur)4;
                if (value.ToString() == "Lanetli")
                    _Turu = (Tur)5;
            }
        }
        private int _Dayaniklilik;
        public int Dayaniklilik
        {
            get { return _Dayaniklilik; }
            set 
            {
                if (Turu.ToString() == "Cuce")
                    _Dayaniklilik = 7;

                if (Turu.ToString() == "Elf")
                    _Dayaniklilik = 7;

                if (Turu.ToString() == "Ork")
                    _Dayaniklilik = 10;

                if (Turu.ToString() == "Insan")
                    _Dayaniklilik = 6;

                if (Turu.ToString() == "Lanetli")
                    _Dayaniklilik = 5;
            }
        }
        private int _Guc;
        public int Guc
        {
            get { return _Guc; }
            set 
            {
                if (Turu.ToString() == "Cuce")
                    _Guc = 3;

                if (Turu.ToString() == "Elf")
                    _Guc = 7;

                if (Turu.ToString() == "Ork")
                    _Guc = 10;

                if (Turu.ToString() == "Insan")
                    _Guc = 5;

                if (Turu.ToString() == "Lanetli")
                    _Guc = 5;
            }
        }
        private int _Can;
        public int Can
        {
            get { return _Can; }
            set
            {
                if (Turu.ToString() == "Cuce")
                    _Can = 75;

                if (Turu.ToString() == "Elf")
                    _Can = 150;

                if (Turu.ToString() == "Ork")
                    _Can = 250;

                if (Turu.ToString() == "Insan")
                    _Can = 100;

                if (Turu.ToString() == "Lanetli")
                    _Can = 300;
            }
        }
        private int _Hiz;
        public int Hiz
        {
            get { return _Hiz; }
            set 
            {
                if (Turu.ToString() == "Cuce")
                    _Hiz = 7;

                if (Turu.ToString() == "Elf")
                    _Hiz = 7;

                if (Turu.ToString() == "Ork")
                    _Hiz = 3;

                if (Turu.ToString() == "Insan")
                    _Hiz = 6;

                if (Turu.ToString() == "Lanetli")
                    _Hiz = 5;
            }
        }
        private int _Zeka;
        public int Zeka
        {
            get { return _Zeka; }
            set 
            {
                if (Turu.ToString() == "Cuce")
                    _Zeka = 7;

                if (Turu.ToString() == "Elf")
                    _Zeka = 7;

                if (Turu.ToString() == "Ork")
                    _Zeka = 3;

                if (Turu.ToString() == "Insan")
                    _Zeka = 8;

                if (Turu.ToString() == "Lanetli")
                    _Zeka = 3;
            }
        } 

        // To Do: Yetenekleri ayarla
        public string TurYetenegi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        // Siniftan gelen ozellikler
        private Sinif _Sinifi;
        public Sinif Sinifi
        {
            get { return _Sinifi; }
            set 
            {
                if (value.ToString() == "Savasci")
                    _Sinifi = (ISinif.Sinif)0;

                if (value.ToString() == "Sovalye")
                    _Sinifi = (Sinif)1;

                if (value.ToString() == "Suikastci")
                    _Sinifi = (Sinif)2;

                if (value.ToString() == "Okcu")
                    _Sinifi = (Sinif)3;

                if (value.ToString() == "Psisik")
                    _Sinifi = (Sinif)4;

                if (value.ToString() == "Buyucu")
                    _Sinifi = (Sinif)5;

                if (value.ToString() == "DogaDostu")
                    _Sinifi = (Sinif)6;

                if (value.ToString() == "KaranlikBuyucu")
                    _Sinifi = (Sinif)7;

                if (value.ToString() == "Asik")
                    _Sinifi = (Sinif)8;
            }
        }

        private ISinif.Silah _Silahi;
        public ISinif.Silah Silahi
        {
            get { return _Silahi; }
            set 
            {
                if (Sinifi.ToString() == "Savasci")
                    _Silahi = (ISinif.Silah)1;

                if (Sinifi.ToString() == "Sovalye")
                    _Silahi = (ISinif.Silah)2;

                if (Sinifi.ToString() == "Suikastci")
                    _Silahi = (ISinif.Silah)3;

                if (Sinifi.ToString() == "Okcu")
                    _Silahi = (ISinif.Silah)4;

                if (Sinifi.ToString() == "Psisik")
                    _Silahi = (ISinif.Silah)7;

                if (Sinifi.ToString() == "Buyucu")
                    _Silahi = (ISinif.Silah)5;

                if (Sinifi.ToString() == "DogaDostu")
                    _Silahi = (ISinif.Silah)2;

                if (Sinifi.ToString() == "KaranlikBuyucu")
                    _Silahi = (ISinif.Silah)6;

                if (Sinifi.ToString() == "Asik")
                    _Silahi = (ISinif.Silah)8;
            }
        }
        private Kalkan _Kalkani;
        public Kalkan Kalkani
        {
            get { return _Kalkani; }
            set 
            {
                if (Sinifi.ToString() == "Savasci")
                    _Kalkani = 0;

                if (Sinifi.ToString() == "Sovalye")
                    _Kalkani = (Kalkan)1;

                if (Sinifi.ToString() == "Suikastci")
                    _Kalkani = 0;

                if (Sinifi.ToString() == "Okcu")
                    _Kalkani = 0;

                if (Sinifi.ToString() == "Psisik")
                    _Kalkani = 0;

                if (Sinifi.ToString() == "Buyucu")
                    _Kalkani = 0;

                if (Sinifi.ToString() == "DogaDostu")
                    _Kalkani = (Kalkan)1;

                if (Sinifi.ToString() == "KaranlikBuyucu")
                    _Kalkani = 0;

                if (Sinifi.ToString() == "Asik")
                    _Kalkani = (Kalkan)1;
            }
        }
        private ISinif.Zirh _Zirhi;
        public ISinif.Zirh Zirhi
        {
            get { return _Zirhi; }
            set 
            {
                if (Sinifi.ToString() == "Savasci")
                    _Zirhi = (ISinif.Zirh)1;

                if (Sinifi.ToString() == "Sovalye")
                    _Zirhi = (ISinif.Zirh)1;

                if (Sinifi.ToString() == "Suikastci")
                    _Zirhi = (ISinif.Zirh)2;

                if (Sinifi.ToString() == "Okcu")
                    _Zirhi = (ISinif.Zirh)2;

                if (Sinifi.ToString() == "Psisik")
                    _Zirhi = (ISinif.Zirh)3;

                if (Sinifi.ToString() == "Buyucu")
                    _Zirhi = (ISinif.Zirh)3;

                if (Sinifi.ToString() == "DogaDostu")
                    _Zirhi = (ISinif.Zirh)2;

                if (Sinifi.ToString() == "KaranlikBuyucu")
                    _Zirhi = (ISinif.Zirh)3;

                if (Sinifi.ToString() == "Asik")
                    _Zirhi = (ISinif.Zirh)2;
            }
        }

        // Oyunda degisecek seyler

        public ISinif.Silah OyundaSilah { get; set; }
        public Kalkan OyundaKalkan { get; set; }
        public ISinif.Zirh OyundaZirh { get; set; }
        public int OyundaDayaniklilik { get; set; }
        public int OyundaGuc { get; set; }
        private int _OyundaCan;
        public int OyundaCan
        {
            get { return _OyundaCan; }
            set 
            {
                if (value <= 0)
                {
                    MessageBox.Show($"{this.Adi} oldu ve macera bitti!!");
                    Application.Exit();
                }

                else
                    _OyundaCan = value;
            }
        }
        public int OyundaHiz { get; set; }
        public int OyundaZeka { get; set; }

    }
}
