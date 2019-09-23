using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenkronKafe.Models
{
    //KafeDb yi bir nevi veri tabanı olarak kullanacağız
    //Siparis türünde nesne tutan Aktif ve Gecmis Siparisler Listesi tanımladık
    //Urun turunde nesne tutan Urunler Listesi tanımladık
    //Parametresiz Contractur metodu çalıştığında yani KafeDb newlendiğinde bu Listeler atanan değişken isimleriyle oluşmuş olacak.


    public class KafeDb
    {
        public List<Siparis> AktifSiparisler { get; set; }
        public List<Siparis> GecmisSiparisler { get; set; }
        public List<Urun> Urunler { get; set; }
        public KafeDb()
        {
            AktifSiparisler = new List<Siparis>();
            GecmisSiparisler = new List<Siparis>();
            Urunler = new List<Urun>();
        }
    }
}
