using System;
using System.Collections.Generic;
using voleybol.odevi;

namespace voleybol.odevi
{
    public class Smacor : Oyuncu
    {
        public Smacor(string isim, int guc, int hiz, int topKontrol)
            : base(isim, guc, hiz, topKontrol, new List<Yetenek> { Yetenek.Smaç, Yetenek.Karşılama,Yetenek.PasAtma,Yetenek.Servis })
        {
        }

        public string SmacYap()
        {
            return Isim+" smaç yapıyor!";
        }

        public string BlokYap()
        {
            return Isim+" blok yapıyor!";
        }
    }
}
