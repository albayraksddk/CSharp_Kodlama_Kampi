using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Product product1 = new Product(); // Classı kullanma biçimi
            product1.Id = 01;
            product1.Adi = "Elma";
            product1.Aciklama = "Amasya Kırmızı";
            product1.Fiyati = 10.99;

            Product product2 = new Product();
            product2.Id = 02;
            product2.Adi = "Karpuz";
            product2.Aciklama = "Diyarbakır Karpuzu";
            product2.Fiyati = 5.45;

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine("ID: " + product.Id);
                Console.WriteLine("ADI: " + product.Adi);
                Console.WriteLine("AÇIKLAMA: " + product.Aciklama);
                Console.WriteLine("FİYAT: " + product.Fiyati + "TL");
                Console.WriteLine("-------------------------");
            }

            // Bölüm 3 Saat 01:03:43 de kaldık,
        }
    }
}


// Do Not Repeat yourself - Clean Code - Best Practice