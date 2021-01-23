using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<K,T>
    {
        K[] index;
        K[] indexTemp;
        T[] value;
        T[] valueTemp;

        public MyDictionary()
        {
            index = new K[0];
            value = new T[0];
        }

        public void Add(K _index,T _value)
        {
            indexTemp = index;

            index = new K[index.Length + 1];
            for (int i = 0; i < indexTemp.Length; i++)
            {
                index[i] = indexTemp[i];
            }
            index[index.Length - 1] = _index;

            valueTemp = value;
            value = new T[value.Length + 1];

            for (int i = 0; i < valueTemp.Length; i++)
            {
                value[i] = valueTemp[i];
            }
            value[value.Length - 1] = _value;
        }

        public void View()
        {
            for (int i = 0; i < index.Length; i++)
            {
                Console.WriteLine("Index : " + index[i] +"  " + "Value : "+value[i]+"\n");
            }
            ;
        }
    }
}
