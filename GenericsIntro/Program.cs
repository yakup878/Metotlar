using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> aylar = new MyList<string>();
            Console.WriteLine(aylar.Length);
            aylar.Add("Temmuz");
            Console.WriteLine(aylar.Length);

            //List<string> aylar2 = new List<string>();
            //Console.WriteLine(aylar2.Count);
        }
    }
}
