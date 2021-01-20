using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{  //intelisense //snippet
    class Product // Entitiy(varlık) bu tip classlarda sadece özellik olur.
    {
        public int Id { get; set; }
        public int CategoryId { get; set; } //referans anahtarı ıkıncı sıraya yazılır.kod okunurluğu için
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }

        public int UnitInStock { get; set; }

        




    }
}
