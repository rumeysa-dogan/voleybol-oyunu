using voleybol.odevi;

namespace voleybol.odevi
{
    public static class Program
    {
            public static void Main(string[] args)
            {
                
                Smacor smacor = new Smacor("Ahmet", 90, 80, 85);
                Console.WriteLine(smacor.Isim+" yetenekleri: "+YetenekleriListele(smacor));
                Console.WriteLine(smacor.Oyna(Yetenek.Smaç));

                
                Libero libero = new Libero("Mehmet", 70, 95, 90);
                Console.WriteLine(libero.Isim+" yetenekleri: "+YetenekleriListele(libero));
                Console.WriteLine(libero.Oyna(Yetenek.Karþýlama));

                
                Pasor pasor = new Pasor("Ali", 85, 80, 92);
                Console.WriteLine(pasor.Isim+" yetenekleri: "+YetenekleriListele(pasor));
                Console.WriteLine(pasor.Oyna(Yetenek.PasAtma));

              
                OrtaOyuncu ortaOyuncu = new OrtaOyuncu("Veli", 88, 75, 87);
                Console.WriteLine(ortaOyuncu.Isim+ "yetenekleri: "+YetenekleriListele(ortaOyuncu));
                Console.WriteLine(ortaOyuncu.Oyna(Yetenek.Blok));
                  Application.Run(new Form1());
            }

            
            public static string YetenekleriListele(Oyuncu oyuncu)
            {
                string yetenekler = "";
                foreach (var yetenek in oyuncu.YetenekListele())
                {
                    yetenekler += yetenek + " ";
                }
                return yetenekler.Trim();
            }

    } 
}
