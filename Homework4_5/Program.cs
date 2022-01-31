using System;

namespace Homework4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dictionary1 = new MyDictionary<int, string>();
            dictionary1.Add(1, "Görkem");
            dictionary1.Add(2, "Etem");
            dictionary1.Add(3, "Irmak");
            dictionary1.Add(4, "etem");

            for (int i = 0; i < 4; i++)
            {
                dictionary1.Value(i);
            }
          
        }
    }
}
