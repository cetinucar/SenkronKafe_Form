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
    public partial class GecmisSiparislerForm : Form
    {
        KafeDb db;
        public GecmisSiparislerForm(KafeDb kafeDb)
        {
            //Bu formun clasında tanımladığımız db nesnesini parametre ile gelen kafedb nesnesine eşitledik
            db = kafeDb;
            InitializeComponent();
            //ekranın ortasında başlamasını istediğim için başlama pozisyonunu değiştirdim
            this.StartPosition = FormStartPosition.CenterScreen;
            //Ekranın boyutu sabitledim
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.MaximizeBox = false;
            dgvGecmisSiparisler.DataSource = db.GecmisSiparisler;
        }
        //Seçim değiştiğinde
        private void DgvGecmisSiparisler_SelectionChanged(object sender, EventArgs e)
        {
           // Eğer seçili değer uzunluğu 1 se içindeki kodlar çalışacak.Bunu yazdık çünkü ilk açıldığında -1 değerini alıyor
            if (dgvGecmisSiparisler.SelectedRows.Count==1)
            {
                //Her satırda bizim sipariş nesnemiz tutuluyor.DatabounItem seçili satırda sipariş nesnesine tür dönüşümü yaparak ulaşmamızı sağlıyor..
                Siparis siparis = (Siparis)dgvGecmisSiparisler.SelectedRows[0].DataBoundItem;
                dgvSiparisDetaylari.DataSource = siparis.SiparisDetaylar;
            }
            
        }
    }
}
