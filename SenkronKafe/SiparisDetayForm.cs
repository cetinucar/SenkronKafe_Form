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
    public partial class SiparisDetayForm : Form
    {
        KafeDb db;
        Siparis siparis;
        BindingList<SiparisDetay> blSiparisDetaylar;
        //Masa taşındığında tetikleyeceğimiz bir event tanımladık
        public event EventHandler MasaTasindi;

        public SiparisDetayForm(KafeDb kafeDb,Siparis siparis)
        {
            //classın nesnesi olan db ve siparisi parametre ile gelen nesnelere eşitledik.siparis nesneleri aynı isimde olduğu için this 
            //keywordünü classın nesnesini belirtmek için kullandık
            db = kafeDb;
            this.siparis = siparis;
            //burda bindinglist hem kaynak olarak db deki veriyi kullanıyor hemde bir değişiklik olduğunda onuda güncellemiş oluyor
            blSiparisDetaylar = new BindingList<SiparisDetay>(siparis.SiparisDetaylar);

            InitializeComponent();
            UrunleriListele();
            MasaTasiHedefleriDoldur();
            //ekranın ortasında başlamasını istediğim için başlama pozisyonunu değiştirdim
            this.StartPosition = FormStartPosition.CenterScreen;
            //Ekranın boyutu sabitledim
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.MaximizeBox = false;
            lblMasaNo.Text = siparis.MasaNo.ToString("00");
            dgvSiparisDetay.DataSource = blSiparisDetaylar;
            //Formu açtığımızda lbl OdemeTutarının bilgisini güncel getirmesi için
            BilgileriGuncelle();
            Text = $"{siparis.MasaNo} No'lu Masa Siparis Detayları";
        }
        //Dolu masaların gözükmemesi için masa nosuna göre aktifsiparişlerde varmı diye soruyorum.Eğer yoksa numarayı comboboxa ekliyorum
        //Önce sinde comboboxu temizliyorum üstüste yazmaması için.çünkü bu metodu tekrar çağıracağım güncellemek için.Masayı taşıdıktan sonra o masanın tekrar comboboxda gözükmemesi gerekiyor.
        private void MasaTasiHedefleriDoldur()
        {
            cboMasaTasiHedef.Items.Clear();
            for (int i = 1; i <= 20; i++)
            {
                if (!db.AktifSiparisler.Any(x=>x.MasaNo==i))
                {
                    cboMasaTasiHedef.Items.Add(i);
                    
                }
            }
            
        }

        private void UrunleriListele()
        {
            //Ürünlerin combobox da alfabetik sırada gelmesi için orderby kullandım ve liste çevirdim
            cboUrun.DataSource = db.Urunler.OrderBy(x=>x.UrunAd).ToList();
        }

        private void BtnUrunEkle_Click(object sender, EventArgs e)
        {
            //Combobox da secili nesneyi ürün  türüne dönüşümü yaparak aldım
            Urun urun = (Urun)cboUrun.SelectedItem;
            //BindingListe Siparis detayı ekledim--Binding List sayesinde dgv de eş zamanlı olarak değişimi göreceğiz
            blSiparisDetaylar.Add(new SiparisDetay { UrunAd=urun.UrunAd,Adet=(int)nudUrunAdet.Value,BirimFiyat=urun.BirimFiyat});
            //Eklendikten sonra tekrar başlangıç değerlerine gelmesi için yazdım
            nudUrunAdet.Value = 1;
            cboUrun.SelectedIndex = 0;
            //Ekledikten sonra lblodemetutarını güncelliyoruz
            BilgileriGuncelle();
        }
       
        private void BilgileriGuncelle()
        {
            lblOdemeTutari.Text = siparis.ToplamTutar().ToString("0.00")+" ₺";
        }
        //dgv den kullanıcı tarafından silindiğindede lblOdemeTutarını güncellemesi için 
        private void DgvSiparisDetay_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            BilgileriGuncelle();
        }
        //hiçbirşey yapmadan olduğu gibi sayfadan ayrılıyor
        private void BtnAnasayfayaDon_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void BtnSiparisİptal_Click(object sender, EventArgs e)
        {
            //Kullanıcıya uyarı vermek için messagebox açtım.Bilgilendirme mesajlarını yazdım.buton olarak Yes-No seçtim ve default olarak seçili butonu no olarak tanımladım.
            DialogResult dr = MessageBox.Show(
                "Tüm Siparişler İptal Edilecektir.Onaylıyor musunuz?",
                "Sipariş İptal Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            //Eğer kullanıcı no yu tıklarsa hiç bişey yapmadan çıkması için return dedim
            if (dr==DialogResult.No)
            {
                return;
            }
            //Sipariş iptalini kullanıcı onaylarsa siparis durumunu iptal,kapanıs zamanı o anki zaman yapıp Aktif siparislerden silip gecmiş siparislere ekliyoruz.DialogResultu ayrıl dönderiyoruz.bu abort ayrıl sayfasındaki cevap değişkenine aktarılacak
            siparis.SiparisDurum = SiparisDurumu.İptal;
            siparis.KapanisZamani = DateTime.Now;
            db.AktifSiparisler.Remove(siparis);
            db.GecmisSiparisler.Add(siparis);
            DialogResult = DialogResult.Abort;
        }

        private void BtnHesabiKapat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                $"Eğer Kullanıcıdan {siparis.ToplamTutar()} ₺ tahsil edildiyse hesap kapatılacak.Onaylıyor musunuz ",
                "Hesap Ödeme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                return;
            }
            //Sipariş durumunu iptalden farklı olarak ödendi yapıyorum
            siparis.SiparisDurum = SiparisDurumu.Odendi;
            siparis.KapanisZamani = DateTime.Now;
            db.AktifSiparisler.Remove(siparis);
            db.GecmisSiparisler.Add(siparis);
            DialogResult = DialogResult.Abort;
        }

        //Butona basıldığında hedef masa noyu combobox da seçilen değere göre belirliyorum ve siparisimizin masano sunu hedefmasano olarak değiştiriyorum.Form sayfasının text özelliğini ve lblmasano yu da siparişe uygun olarak güncelliyorum.
        private void BtnMasaTasi_Click(object sender, EventArgs e)
        {
            if (cboMasaTasiHedef.SelectedIndex==-1)
            {
                return;
            }
            int hedefMasaNo =Convert.ToInt32(cboMasaTasiHedef.SelectedItem);
            siparis.MasaNo = hedefMasaNo;
            lblMasaNo.Text = hedefMasaNo.ToString();
            Text = $"{siparis.MasaNo} No'lu Masa Siparis Detayları";
            //Taşıdıktan sonra başlangıç halini alması için 
            cboMasaTasiHedef.SelectedIndex = -1;
            //Masayı taşıdım ama heedef masalar arasında hala bu masa var.Onun için comboboxı doldurduğum metodu tekrar çağırıyorum
            MasaTasiHedefleriDoldur();
            //Eventi tanımlayacağımız metodu oluşturdum
            MasaTasindiginda(EventArgs.Empty);
            
          
        }
        //eğer MasaTasindi eventine metot tanımlanmışsa çalışsın diyorum
        private void MasaTasindiginda(EventArgs args)
        {
            if (MasaTasindi!=null)
            {
                MasaTasindi(this, args);
            }
        }

    }
}
