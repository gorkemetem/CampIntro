using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void ekleme(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " " + musteri.SurName + " müşterisi sisteme eklendi.");
            Console.WriteLine("*****************************");
        }

        public void listeleme(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Name + " " + musteri.SurName);
            }
            Console.WriteLine("*****************************");
        }

        public void silme(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " " + musteri.SurName + " müşterisi sistemden silindi.");
        }
    }
}
