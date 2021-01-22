using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> aylar = new MyList<string>();
            aylar.Add("Temmuz");

            List<string> aylar2 = new List<string>();
            Console.WriteLine(aylar2.Count);
        }
    }
}
