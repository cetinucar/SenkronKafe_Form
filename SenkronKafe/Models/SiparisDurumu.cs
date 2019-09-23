using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenkronKafe.Models
{
    //Siparis Durum diye class olusturduk ve enum yaptık
    //Sayısal değerler karmaşıklığa neden olacağı için enum sayesinde her sayısal değerin neyi ifade edeceğini burda tanımlamış oluyoruz
   public enum SiparisDurumu
    {
        Aktif,
        Odendi,
        İptal
    }
}
