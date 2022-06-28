using System;

namespace Ders2_Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Birden Fazla Condition uygulama

            //int yas = 0;
            //string InputYas, sonuc;


            //Console.WriteLine("Lütfen Yaşınızı Giriniz: ");

            //InputYas = Console.ReadLine();

            //yas = Convert.ToInt32(InputYas);

            //sonuc = yas < 25 ? "A Grubundasınız!" : (yas == 25 ? "B Grubundasınız!" : "C Grubundasınız");

            //Console.WriteLine("Yaşınız: " + yas);
            //Console.WriteLine(sonuc);

            #endregion

            #region Ternary Operatoru Deneme

            int sayi1, sayi2, DegerSonucu;
            string kullaniciSayi1, kullaniciSayi2;

            Console.Write("Lütfen 1.Sayıyı Giriniz: ");
            kullaniciSayi1 = Console.ReadLine();

           
            if (kullaniciSayi1 == "")
            {
                Console.WriteLine("Lütfen Sayı Girmeyi unutmayınız!");
                Console.Write("Lütfen 1.Sayıyı Giriniz: ");
                kullaniciSayi1 = Console.ReadLine();
            }
           
            Console.Write("Lütfen 2.Sayıyı Giriniz: ");
            kullaniciSayi2 = Console.ReadLine();

            if (kullaniciSayi2 =="")
            {
                Console.WriteLine("Lütfen Sayı Girmeyi unutmayınız!");
                Console.Write("Lütfen 2.Sayıyı Giriniz: ");
                kullaniciSayi2 = Console.ReadLine();
            }
                        

            sayi1 = Convert.ToInt32(kullaniciSayi1);
            sayi2 = Convert.ToInt32(kullaniciSayi2);

            DegerSonucu = sayi1 > sayi2 ? (sayi1 - sayi2) : (sayi2 * sayi1);

            Console.WriteLine("Değer Sonucunuz: " + DegerSonucu);


            #endregion


        }
    }
}
