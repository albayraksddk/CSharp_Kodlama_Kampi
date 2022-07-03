using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    public class Product
    {
        // property - özellik 
        // Özellik tanımlamak için yani o klas içinde tutulacak değişkenlerin string mi integer mı olduğunu tanımlar.

        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }

    }
}
