
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voleybol.odevi
{
    public class OrtaOyuncu : Oyuncu
    {
        public OrtaOyuncu(string isim, int guc, int hiz, int topKontrol)
            : base(isim, guc, hiz, topKontrol, new List<Yetenek> { Yetenek.Karşılama,Yetenek.PasAtma ,Yetenek.Servis,Yetenek.Blok})
        {
        }

        public string ServisYap()
        {
            return "servis yapıyor!";
        }
        public string BlokYap()
        {
            return " blok yapıyor!";
        }
    }


}
