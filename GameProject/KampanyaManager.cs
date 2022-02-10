using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class KampanyaManager : IKampanyaService
    {
        
        public void Add(Kampanya kampanya)
        {
            Console.WriteLine("Yeni kampanya eklendi.");
        }

        public void Delete(Kampanya kampanya)
        {
            Console.WriteLine("Kampanya eklendi.");
        }

        public void Update(Kampanya kampanya)
        {
            Console.WriteLine("Kampanya güncellendi.");
        }
    }
}
