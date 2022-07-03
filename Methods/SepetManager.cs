using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    internal class SepetManager
    {
        //naming convention 
        //Eğer bir  yerde normal parantez kullanılıyorsa orada metot  çalışıyordur. 
        /*Burada bir metot oluştururken Ekle metodunda neyi ekleyeceğimizi parantezin içine yazdık. 
         * Yani bu metot için parametre tanımladık
         * Burada Buyuk harfle yazılan Product - Class ın tipini, küçük harfli olan product ise o metodu kullanmak için verdiği isim
         * 
         */
        public void Ekle(Product product) // bu encapsulation yapılmış hali. burada Product class ının içine tanımlayarak kapsülledik.  
        {
            Console.WriteLine("Tebrikler. Spete Eklendi! : " + product.Adi + " (" + product.Aciklama + ")");
        }

        //bir class ın içinde birden fazla method olabilir. 

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi) // bu encapsulation yapılmamış hali
        {
            Console.WriteLine("Tebrikler. Spete Eklendi! : " + urunAdi);
        }
    }
}

