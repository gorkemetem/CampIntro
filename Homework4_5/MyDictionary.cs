using System;
using System.Collections.Generic;
using System.Text;

namespace Homework4_5
{
    class MyDictionary<T1,T2>
    {
        T1[] keys;
        T2[] values;

        public MyDictionary()
        {
            keys = new T1[0];
            values = new T2[0];
        }
        public void Add(T1 key, T2 value)
        {
            T1[] tempKey = keys;
            keys = new T1[keys.Length + 1];
            T2[] tempValue = values;
            values = new T2[values.Length + 1];

            for (int i = 0; i < keys.Length-1; i++)
            {
                keys[i] = tempKey[i];
                values[i] = tempValue[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }

        public void Value(int key)
        {
            Console.WriteLine(values[key]);
        }
    }
}
