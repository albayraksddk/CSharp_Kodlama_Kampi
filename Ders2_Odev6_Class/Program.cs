using System;

namespace Ders2_Odev6_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urunler urun1 = new Urunler();
            urun1.ProductID = "SER00001";
            urun1.Category = "Elektronik";
            urun1.ProductName = "Televizyon";

            Urunler urun2 = new Urunler();
            urun2.ProductID = "SER00002";
            urun2.Category = "Elektronik";
            urun2.ProductName = "Cep Telefonu";

            Urunler urun3 = new Urunler();
            urun3.ProductID = "SER00003";
            urun3.Category = "Beyaz Eşya";
            urun3.ProductName = "Buzdolabı";

            Urunler[] urunlers = new Urunler[] { urun1, urun2, urun3 };
            foreach (var item in urunlers)
            {
                Console.WriteLine("Urun No :" + item.ProductID);
                Console.WriteLine("Kategori :" + item.Category);
                Console.WriteLine("Ürün Adı : " + item.ProductName);
                Console.WriteLine("-------------------------------");
            }


        }
    }
}
