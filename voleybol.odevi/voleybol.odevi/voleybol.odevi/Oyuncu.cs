using System;
using System.Collections.Generic;
using System.Linq;

namespace voleybol.odevi
{
    public enum Yetenek
    {
        Smaç,
        Blok,
        Servis,
        PasAtma,
        Karşılama
    }

    public abstract class Oyuncu
    {
        public List<Yetenek> YetenekListesi { get; set; }

        public string Isim { get; set; }
        public int Guc { get; set; }
        public int Hiz { get; set; }
        public int TopKontrol { get; set; }

        public Oyuncu(string isim, int guc, int hiz, int topKontrol, List<Yetenek> yetenekListesi)
        {
            Isim = isim;
            Guc = guc;
            Hiz = hiz;
            TopKontrol = topKontrol;
            YetenekListesi = yetenekListesi;
        }

        public string Oyna(Yetenek yetenek)
        {
            if (YetenekListesi.Contains(yetenek))
            {
                return Isim+ " "+yetenek +"  kullandı!";
            }
            return Isim+ yetenek+" yeteneğini kullanamaz!";
        }

        public List<string> YetenekListele()
        {
            return YetenekListesi.Select(y => y.ToString()).ToList();
        }
    }
}
