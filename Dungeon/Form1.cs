using Dungeon.Concrete;
using Dungeon.Interface;

namespace Dungeon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbBaslangicTur.Items.AddRange(Enum.GetNames(typeof(ITur.Tur)));
            cmbBaslangicSinif.Items.AddRange(Enum.GetNames(typeof(ISinif.Sinif)));
            cmbBaslangicSinif.SelectedIndex = 0;
            cmbBaslangicTur.SelectedIndex = 0;
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            #region Baslangic Atamalari
            Karakter karakter = new Karakter();
            karakter.Adi = txtBaslangicAd.Text;
            karakter.Turu = (ITur.Tur)Enum.Parse(typeof(ITur.Tur),cmbBaslangicTur.Text.ToString());
            karakter.Sinifi = (ISinif.Sinif)Enum.Parse(typeof(ISinif.Sinif), cmbBaslangicSinif.Text.ToString());

            // Atamalarin olmasi icin yapilan bos atamalar
            karakter.Dayaniklilik = 0;
            karakter.Can = 0;
            karakter.Hiz = 0;
            karakter.Zeka = 0;
            karakter.Guc = 0;
            karakter.Zirhi = (ISinif.Zirh)117;
            karakter.Silahi = (ISinif.Silah)117;
            karakter.Kalkani = (ISinif.Kalkan)117;
            karakter.TecrubePuani = 0;
            karakter.Altin = 10;

            // Oyunda kullanilacak atamalar. Bunlara ek olarak karakter.Adi, karakter.Turu ve karakter.Sinifi
            karakter.OyundaSilah = karakter.Silahi;
            karakter.OyundaZirh = karakter.Zirhi;
            karakter.OyundaKalkan = karakter.Kalkani;

            karakter.OyundaDayaniklilik = karakter.Dayaniklilik;
            karakter.OyundaCan = karakter.Can;
            karakter.OyundaHiz = karakter.Hiz;
            karakter.OyundaZeka = karakter.Zeka;
            karakter.OyundaGuc = karakter.Guc;
            #endregion

            OyunEkrani oyunEkrani = new OyunEkrani(karakter);

            this.Hide();
            
            oyunEkrani.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}