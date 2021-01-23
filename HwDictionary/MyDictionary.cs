using System;
using System.Collections.Generic;
using System.Text;

namespace HwDictionary
{
    class MyDictionary<TKey, TValue>
    {

        TKey[] keys;
        TValue[] values;



        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];


        }
        public void Add(TKey key,TValue value)
        {
            TKey[] keyArray = keys;
            TValue[] valueArray = values;
            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            for (int i = 0; i < keyArray.Length; i++)
            {
                for (int j = 0; j < valueArray.Length; j++)
                {
                    keys[i] = keyArray[i];
                    values[j] = valueArray[j];
                }

            }

            

        }

        public int Count
        {
            get { return keys.Length; }
        }




    }
}
