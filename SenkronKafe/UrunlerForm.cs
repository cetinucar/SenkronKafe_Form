using SenkronKafe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenkronKafe
{
    public partial class UrunlerForm : Form
    {
        KafeDb db;
        BindingList<Urun> blUrunler;
        public UrunlerForm(KafeDb kafeDb)
        {
            //Forumda kullanacağımız db nesnesini parametre ile gelen db nesnesine eşitledik
            //blUrunler kaynak olarak db deki Urunleri kullanıyor ve bir değişiklikte orayıda güncelliyor
            db = kafeDb;
            blUrunler = new BindingList<Urun>(db.Urunler);
            InitializeComponent();
            //Kolonları kendisi oluşturmaması için yazdık.Kolonları kendimiz elle girdik
            dgvUrunler.AutoGenerateColumns = false;
            dgvUrunler.DataSource = blUrunler;
            //ekranın ortasında başlamasını istediğim için başlama pozisyonunu değiştirdim
            this.StartPosition = FormStartPosition.CenterScreen;
            //Ekranın boyutu sabitledim
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.MaximizeBox = false;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun { UrunAd = txtUrunAd.Text, BirimFiyat = nudBirimFiyat.Value };
            blUrunler.Add(urun);
            txtUrunAd.Clear();
            nudBirimFiyat.Value = 1;
        }
    }
}
