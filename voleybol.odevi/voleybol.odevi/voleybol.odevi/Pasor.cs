
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using voleybol.odevi;

namespace voleybol.odevi
{
    public class Pasor : Oyuncu, IBlok, IServis, ISmac
    {
        public Pasor(string isim, int guc, int hiz, int topKontrol)
            : base(isim, guc, hiz, topKontrol, new List<Yetenek> { Yetenek.PasAtma, Yetenek.Blok ,Yetenek.Karşılama,Yetenek.Smaç,Yetenek.Blok,Yetenek.Servis})
        {
        }

        public string SmacYap()
        {
            return " smaç yapıyor!";
        }

        public string BlokYap()
        {
            return " blok yapıyor!";
        }

        public string ServisYap()
        {
            return "servis yapıyor!";
        }

    }


}
