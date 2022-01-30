using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = "123456789";
            musteri1.Name = "Görkem";
            musteri1.SurName = "Irmak";
            musteri1.Tel = 123;

            Musteri musteri2 = new Musteri();
            musteri2.Id = "123456987";
            musteri2.Name = "Etem";
            musteri2.SurName = "Irmak";
            musteri2.Tel = 321;

            Musteri musteri3 = new Musteri();
            musteri3.Id = "123654789";
            musteri3.Name = "Görkem Etem";
            musteri3.SurName = "Irmak";
            musteri3.Tel = 213;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager mustermanager = new MusteriManager();
            mustermanager.ekleme(musteri1);
            mustermanager.listeleme(musteriler);
            mustermanager.silme(musteri3);
        }
    }
}
