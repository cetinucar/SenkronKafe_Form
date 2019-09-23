using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenkronKafe.Models
{
   public class SiparisDetay
    {
        public string UrunAd { get; set; }
        public decimal BirimFiyat { get; set; }
        public int Adet { get; set; }
        public decimal Tutar()
        {
            return BirimFiyat * Adet;
        }
    }
}
