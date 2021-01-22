using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //void -> emir kipi git yap bitir <- (ekle,sil,güncelle vs.)
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + "Eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "Güncellendi.");
        }
        //geriye döndür
        public int Topla(int sayi1, int sayi2  /*, params int[] numbers*/)
        {
            return sayi1 + sayi2;
        } 
        public void Topla2(int sayi1, int sayi2 )
        {
            Console.WriteLine(sayi1+sayi2);
        }
    }
}
