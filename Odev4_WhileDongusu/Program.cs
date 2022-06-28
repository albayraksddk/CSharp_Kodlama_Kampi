using System;

namespace Odev4_WhileDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region While Döngüsü Genel Kullanımı

            //while (true) // Şartımız true olduğu süre boyunca döngümüz çalışmaya devam eder. 
            // {
            /*
             * Aşağıdaki durumlar olana kadar devam eder. 
             * 
             * 1-While(false) olana kadar devam eder. 
             * 2-Döngü içerisinde bir yerde Break; anahtar kelimesini kullanırsak döngüden çıkar
             */
            //}

            #endregion

            #region Örnek Kullanım 1: Ekrana 1-10 a kadar sayıların değerlerini yazdırma
            // for döngüsü ile işlemin cevabı

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("--------------------------");

            int sayac = 1;

            while (sayac <= 10)
            {
                Console.WriteLine(sayac);
                sayac++; //while for döngüsü gibi aldığı değeri arttırıp azaltmaz sadece true/false durumuna bakar
                         //Dolayısıyla burada aldığı değeri 1 arttırmak gerekir
            }

            #endregion

        }
    }
}
