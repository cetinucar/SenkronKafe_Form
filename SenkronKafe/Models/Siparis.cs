using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenkronKafe.Models
{
   public class Siparis
    {
        public int MasaNo { get; set; }
        public List<SiparisDetay> SiparisDetaylar { get; set; }
        //Datetime ın nulable olması için Datetime'dan sonra '?' koyduk
        public DateTime? AcilisZamani { get; set; }
        public DateTime? KapanisZamani { get; set; }
        public SiparisDurumu SiparisDurum { get; set; }
        //Siparis her newlendiğinde veya açıldığında yeni bir SiparisDetaylar listesi oluşacak ve siparisin AcılısZamanı o anki zamana eşit olacak.
        public Siparis()
        {
            SiparisDetaylar = new List<SiparisDetay>();
            AcilisZamani = DateTime.Now;
        }
        //SiparisDetaylardaki Tutar metodunun dönderdiği değerleri sum metoduyla topladık ve ToplamTutar metodunu oluşturduk
       public decimal ToplamTutar()
        {
            return SiparisDetaylar.Sum(x => x.Tutar());
        }
    }
}
