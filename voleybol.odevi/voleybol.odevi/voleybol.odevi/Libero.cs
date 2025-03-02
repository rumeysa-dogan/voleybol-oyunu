
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using voleybol.odevi;

namespace voleybol.odevi
{
    public class Libero : Oyuncu, IServis
    {
        public Libero(string isim, int guc, int hiz, int topKontrol)
            : base(isim, guc, hiz, topKontrol, new List<Yetenek> { Yetenek.PasAtma,Yetenek.Karşılama,Yetenek.Servis  })
        {
        }




        public string ServisYap()
        {
            return "servis yapıyor!";
        }
    }
}
