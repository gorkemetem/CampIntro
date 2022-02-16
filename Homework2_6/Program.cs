using System;

namespace Homework2_6
{
    class Program
    {
        static void Main(string[] args)
        {

            Product urun1 = new Product();
            urun1.ad = "ÜRÜN1";
            urun1.fiyat = 15;
            urun1.indirim = "indirim1";

            Product urun2 = new Product();
            urun2.ad = "ÜRÜN2";
            urun2.fiyat = 17;
            urun2.indirim = "indirim2";

            Product urun3 = new Product();
            urun3.ad = "ÜRÜN3";
            urun3.fiyat = 16;
            urun3.indirim = "indirim3";

            Product[] urunler = new Product[] {urun1, urun2, urun3 };

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].ad + " - " + urunler[i].fiyat);
            }

            Console.WriteLine("******************************");

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.ad + " - " + urun.fiyat);
            }

            Console.WriteLine("******************************");

            int j = 0;
            while (j < urunler.Length)
            {
                Console.WriteLine(urunler[j].ad + " - " + urunler[j].fiyat);
                j++;
            }
        }
    }

    class Product
    {
        public string ad { get; set; }
        public int fiyat { get; set; }
        public string indirim { get; set; }
    }
}
