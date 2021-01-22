using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] aylar = new string[] { "Mart", "Temmuz", "Kasım" };
            //Console.WriteLine(aylar[0]);
            //Console.WriteLine(aylar[1]);
            //Console.WriteLine(aylar[2]);
            //aylar = new string[4];//yeni bir dizi oluşturdun
            //aylar[3] = "Ocak";
            //Console.WriteLine(aylar[3]);
            //Console.WriteLine(aylar[0]);

            List<string> isimler2 = new List<string> { "Şubat", "Temmuz", "Kasım" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("Ekim");
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
//control+k+c -> yorum yap  ctrl+k+u -> yorumdan çıkar
