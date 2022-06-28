using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type Safety = tip guvenligi  
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false; // şart bloklarını çıkarır
            double dolarDun = 16.01;
            double dolarBugun = 13.01;

            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(ogrenciSayisi);
            Console.WriteLine(faizOrani);

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Lütfen Giriş Yapınız!");
            }

            if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Dolar Arttı");   
            }
            else if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Dolar Azaldı");
            }
            else
            {
                Console.WriteLine("Dolar Aynı Kaldı");
            }

        }
    }
}
