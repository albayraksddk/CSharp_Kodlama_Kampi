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
            product1.StokAdedi = 500;

            Product product2 = new Product();
            product2.Id = 02;
            product2.Adi = "Karpuz";
            product2.Aciklama = "Diyarbakır Karpuzu";
            product2.Fiyati = 5.45;
            product2.StokAdedi = 5000;

            Product product3 = new Product();
            product3.Id = 03;
            product3.Adi = "Patates";
            product3.Aciklama = "Ödemiş Patatesi";
            product3.Fiyati = 12.99;
            product3.StokAdedi = 1185;

            

            Product[] products = new Product[] { product1, product2, product3};

            foreach (Product product in products) //buradaki küçük harfle yazılan product alias olarak kullanılır. Büyük harfli olan Product ise veri tipini verir. foreach te var olarak da kalabilir.
            {
                Console.WriteLine("ID: " + product.Id);
                Console.WriteLine("ADI: " + product.Adi);
                Console.WriteLine("AÇIKLAMA: " + product.Aciklama);
                Console.WriteLine("FİYAT: " + product.Fiyati + "TL");
                Console.WriteLine("STOK: "+product.StokAdedi + "KG");
                Console.WriteLine("-------------------------");
            }

            Console.WriteLine("------------------Metotlar-------------");

            //instance - örnek : burada class örneği oluşturuyoruz.
            //Encapsulation -  nesne yönelimli programlamada herhangi bir nesnenin metotlarını, verilerini ve değiskenlerini
            //diğer nesnelerden saklayarak ve bunlara erişimini sınırlandırarak yanlış kullanımlardan koruyan bir konsepttir.

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);
            sepetManager.Ekle(product3);    


            sepetManager.Ekle2("Armut", "Ahlat Armutu", 10.99, 5);
            sepetManager.Ekle2("Elma", "Amasya Elması", 12.80, 10);
            sepetManager.Ekle2("Karpuz", "Adana Karpuzu", 3.49, 20);




        }
    }
}


// Do Not Repeat yourself - Clean Code - Best Practice