using System;

namespace Ders2_Odev3_Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Switch(ifade)
             * {
             * 
             * case kontrol1 :
             * Çalışacak olan işlemler
             * break;
             * 
             * case kontrol2 :
             * çalışacak olan işlemler
             * break;
             * 
             * default: (if deki else yapısı gibi)
             * çalışacak olan işlemler
             * break;
             * }
             * 
             * 
             */
            Console.Write("Hangi Ay: ");
            string kullanicidanGelen = Console.ReadLine();
            switch (kullanicidanGelen)
            {
                case "Ocak": // Burada 2 adet case koşulu arka arkaya gelince veya anlamını taşır
                case "Nisan":
                    Console.WriteLine("01");
                    break;
                case "Şubat":
                    Console.WriteLine("02");
                    break;
                case "Mart":
                    Console.WriteLine("03");
                    break;
                default:
                    Console.WriteLine("Belirtilen değerin dışında bir değer girişi yaptınız");    
                    break;
            }

        }
    }
}
