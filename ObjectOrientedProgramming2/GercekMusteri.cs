using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming2
{
    //individual->Bireysel/gercek
    class GercekMusteri : Musteri //GercekMusteri:Musteri -> miras - inheratance
    {
        public string TcNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
}
