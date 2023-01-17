using Dungeon.Concrete;
using Dungeon.Dusmanlar;
using Dungeon.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dungeon
{
    public partial class OyunEkrani : Form
    {
        Karakter oyunIciKarakter = new Karakter();
        Kurt kurt = new Kurt();
        public OyunEkrani(Karakter karakter)
        {
            InitializeComponent();
            oyunIciKarakter = karakter;
            lblSenaryo.Text = $"KURT({kurt.Can}) SALDIRDI!! Ne yapacagini sec:\n1) Saldir\n2) Kac";
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OyunEkrani_Load(object sender, EventArgs e)
        {
            lsbHarita.Items.AddRange(Enum.GetNames(typeof(Bolgeler)));
            StatlariGoster();
        }

        public void StatlariGoster()
        {
            lblXp.Text = $"XP: {oyunIciKarakter.TecrubePuani}";
            lblAltin.Text = $"Altin: {oyunIciKarakter.Altin}";
            lblCan.Text = $"Can: {oyunIciKarakter.OyundaCan}";
            lblDayaniklilik.Text = $"Dayaniklilik: {oyunIciKarakter.OyundaDayaniklilik}";
            this.lblStatlar.Text = $"{oyunIciKarakter.Adi.ToUpper()} - {oyunIciKarakter.Turu} {oyunIciKarakter.Sinifi}\nHiz: {oyunIciKarakter.OyundaHiz}\nZeka: {oyunIciKarakter.OyundaZeka}\nGuc: {oyunIciKarakter.OyundaGuc}\nZirh: {oyunIciKarakter.OyundaZirh}\nSilah: {oyunIciKarakter.OyundaSilah}\nAclik: {oyunIciKarakter.AclikDurumu}\nZehirlenme: {oyunIciKarakter.ZehirlenmeDurumu}\nKalkan: {oyunIciKarakter.OyundaKalkan}";
        }

        private void btnSecim2_Click(object sender, EventArgs e)
        {
            lblSenaryo.Text = $"Hic hasar almadan kacmayi basardin!";
            StatlariGoster();
        }

        private void btnSecim1_Click(object sender, EventArgs e)
        {
            if (kurt.Can <= 0)
                lblSenaryo.Text = "Kurt oldu, artik yoluna devam etme zamani...";
            else
                IlkSavas();
        }

        void IlkSavas()
        {
            if (oyunIciKarakter.OyundaCan <= 0)
            {
                MessageBox.Show($"{oyunIciKarakter.Adi} oldu ve macera bitti!!");
                Application.Exit();
            }
            kurt.Saldir();
            oyunIciKarakter.OyundaCan -= kurt.Hasar;
            if (oyunIciKarakter.OyundaDayaniklilik > 0)
            {
                oyunIciKarakter.OyundaDayaniklilik--;
                kurt.Can -= 20;
                lblSenaryo.Text = $"Kurt sana {kurt.Hasar} vurdu, kalan Canin: {oyunIciKarakter.OyundaCan}!\nKurta 20 Vurdun! Kalan Cani: {kurt.Can}";

            }
            else if (oyunIciKarakter.OyundaCan <= 0)
                lblSenaryo.Text = $"OLDUN";

            else
                lblSenaryo.Text = $"DAYANIKLILIK YOK! Kurt sana {kurt.Hasar} vurdu, kalan Canin: {oyunIciKarakter.OyundaCan}!\nKalan Cani: {kurt.Can}";
            StatlariGoster();

            if (kurt.Can <= 0)
            {
                lblSenaryo.Text = $"Tebrikler!! Kurt oldu.";
            }
        }
    }
}
