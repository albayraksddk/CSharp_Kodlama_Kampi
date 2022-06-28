using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlaya Başlangınç için Temel Kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine("-----------Bitti-------------");


            //array - dizi
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlaya Başlangınç için Temel Kurs", "Java", "Python", "C#" };

            for (int i = 0; i < kurslar.Length; i++) //+=2 i yi 2ser arttirir. // kurslar.Length burada array in eleman sayısı kadar döngü çalıştırır
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("-----------For Bitti-------------");

            foreach (string kurs in kurslar) //Dizi temelli yapıları tek tek dönmeye yarar 
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - footer");
        }
    }
}
