using SenkronKafe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SenkronKafe
{
    public partial class Form1 : Form
    {
        KafeDb db;
        public Form1()
        {
            InitializeComponent();
            VerileriOku();
            MasalariYukle();
            //ekranın ortasında başlamasını istediğim için başlama pozisyonunu değiştirdim
            this.StartPosition = FormStartPosition.CenterScreen;
            //Ekranın boyutu sabitledim
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.MaximizeBox = false;
            
           // OrnekUrunleriYukle();
        }
        //Burda Serilizerda çalışacağım tipi  belirttim ve hangi dosyayı okuyacağımı söyledim.Deserialize ederekte okuyup nesneye dönüştürüyorum ve en son streamreader ı kapatıyorum.
        private void VerileriOku()
        {
            //Dosyayı bulamaması durumuna karşı hata vermemesi için try catch içine aldık.
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(KafeDb));
                StreamReader sr = new StreamReader("veri.xml");
                db = (KafeDb)ser.Deserialize(sr);
                sr.Close();
            }
            catch (Exception)
            {
                db = new KafeDb();
                
            }
            
        }

        private void OrnekUrunleriYukle()
        {
            db.Urunler.Add(new Urun { UrunAd = "Kola", BirimFiyat = 4.5m });
            db.Urunler.Add(new Urun { UrunAd = "Su", BirimFiyat = 1.5m });
        }

        private void MasalariYukle()
        {
            //her seferinde bir daha yüklememsi için önce temizliyoruz.çünkü bu metodu hesabı iptal ettiğimizde ve kapattığımızda tekrar çağıracağız
            lvwMasalar.Items.Clear();

            //İmage List oluşuruyoruz bos ve dolu masa resimlerini bu liste atıcaz
            ImageList ilist = new ImageList();

            //imageKeyleri ve yerini belirtiyoruz ve imageliste atıyoruz
            ilist.Images.Add("bos", Properties.Resources.masabos);
            ilist.Images.Add("dolu", Properties.Resources.masadolu);
           
            //boyutunu ayarladık
            ilist.ImageSize =new Size (64, 64);
           
            //Listviewde kullanabilmek için lvwmasaların largeimagelistine eşitliyoruz
            lvwMasalar.LargeImageList = ilist;
            
            //for döngüsüyle list view item oluşturuyorum içine masa no sunu yazdırıyorum.Böylece döngü sayesinde 20 masa oluşmuş oluyor
            //eğer Aktif siparişlerde dönen i nolu masa numarası varsa masa yesil değilse masa gri olarak yükleniyor
            ListViewItem lvi;
            for (int i = 1; i <= 20; i++)
            {
                lvi = new ListViewItem($"Masa:{i}");
                if (db.AktifSiparisler.Any(x=>x.MasaNo==i))
                {
                    lvi.ImageKey = "dolu";
                }
                else
                {
                    lvi.ImageKey = "bos";
                }
                
                
                lvi.Tag = i;
                lvwMasalar.Items.Add(lvi);
                
            }
        }

        private void LvwMasalar_DoubleClick(object sender, EventArgs e)
        {
            //lwv masalardaki secili itemlerden ilkini getirerek tıklanan item ı buluyorum
            ListViewItem tiklanan = lvwMasalar.SelectedItems[0];
            //itemin tagını alarak masaNo adlı değişkene eşitliyorum
            //Tag object türünde nesne dönderdiği için int olarak tür dönüşümü yapıyorum
            int masaNo =(int)tiklanan.Tag;
            //Tıklanan itemin imagekey ini dolu yapıyorum eğer daha önce sipariş açılmadıysa masanın dolu gözükmesi için
            tiklanan.ImageKey = "dolu";
            //Eğer aktif siparişlerde tikladığımız masaYa ait sipariş varsa onu getiriyoruz
            //Siparis yoksa siparisimiz null oluyor 
            Siparis siparis = db.AktifSiparisler.FirstOrDefault(x => x.MasaNo == masaNo);
            //Siparisimiz null değer aldıysa yani Aktif siparislerde tıkladığımız masaya ait bir siparis yoksa o masaya ait yeni bir siparis açıyoruz ve KafeDb türündeki db mizin AktifSiparisler Listesine ekliyoruz
            if (siparis==null)
            {
                //Bu newleme ile birlikte  Siparis clasına ait constractor çalıştı.Açılış zamanı şuanki zamana eşitlendi
                //ve Sipariş detaylar listesi Oluşmuş oldu.
                siparis = new Siparis();
                siparis.MasaNo = masaNo;
                db.AktifSiparisler.Add(siparis);
            }
            //Sipariş formumuzu açmak için oluşturuyoruz ve db ve siparis nesnemizi ordada kullanmak için parametre olarak gönderiyoruz
            SiparisDetayForm sipDetayForm = new SiparisDetayForm(db,siparis);
            //Masa tasindiğinda Masatasindi eventini tetikliyorum
            sipDetayForm.MasaTasindi += SipDetayForm_MasaTasindi;
            //Formdan dönen DialogResulta göre işlem yapmak için onu cevap değişkenine atadık
            DialogResult cevap = sipDetayForm.ShowDialog();
            //hesabı kapattığımızda veya iptal ettiğimizde abort dönecek.bu durumda masaları tekrar yüklediğimizde o siparişi aktif siparişlerden sildiğimiz için o masa artık yeşil olmayacak
            if (cevap==DialogResult.Abort)
            {
                MasalariYukle();
            }
        }

       // MasaTasindi eventi tetiklendiğinde çalışacak metodu tanımladım.Masa taşınırsa lvw masalarda masalar tekrar yüklenecek ve taşınan masa dolu olarak gözükmeyecek
        private void SipDetayForm_MasaTasindi(object sender, EventArgs e)
        {
            MasalariYukle();
        }

        //Urunler butonuna tıkladığımızda ÜrünlerFormu açılacak
        private void TsmiUrunler_Click(object sender, EventArgs e)
        {
            // Urunler formuna parametre olarak db nesnesini yolluyoruz.içindeki Urunler listesini oradada kullanabilmek için
            UrunlerForm frmUrunler = new UrunlerForm(db);
            frmUrunler.ShowDialog();
        }

        //Gecmis Siparisler butonuna tıkladığımızda GecmisSiparisler formu açılacak
        private void TsmiGecmisSiparisler_Click(object sender, EventArgs e)
        {
            // GecmisSiparisler formuna parametre olarak db nesnesini yolluyoruz.içindeki GecmisSiparisler listesini oradada kullanabilmek için
            GecmisSiparislerForm frmGecmisSiparisler = new GecmisSiparislerForm(db);
            frmGecmisSiparisler.ShowDialog();
            
        }

        //Form kapanırken verileri kaydediyorum
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           VerileriKaydet();
        }

        //Serializerda çalışacağım tipi belirtiyorum streamwriter a hangi dosyaya yazacığını belirttim.db nesnesini serialize ederek xml olarak harddiske kaydediyorum ve en son streamwriter ı kapatıyorum. 
        private void VerileriKaydet()
        {
            XmlSerializer ser = new XmlSerializer(typeof(KafeDb));
            StreamWriter sw = new StreamWriter("veri.xml");
            ser.Serialize(sw, db);
            sw.Close();
        }
    }
}
