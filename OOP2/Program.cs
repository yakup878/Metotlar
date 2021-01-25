using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Yakup Bekar
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.TcNo = "12345678910";
            musteri1.Ad = "Yakup";
            musteri1.Soyad = "Bekar";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "98765";
            musteri2.SirketAdi = "YKP YAKUP";
            musteri2.VergiNo = "4587551";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
        }
    }
}
