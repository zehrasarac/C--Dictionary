using System;
using System.Collections.Generic;
using System.Text;
namespace GDictionary
{
    class MyDictionary<T1, T2>
    {
        T1[] t1s;
        T2[] t2s;

        public MyDictionary()
        {
            t1s = new T1[0];
            t2s = new T2[0];
        }

        public void Add(T1 t1, T2 t2)
        {
            T1[] tempt1 = t1s;
            T2[] tempt2 = t2s;

            t1s = new T1[t1s.Length+1];
            t2s = new T2[t2s.Length + 1];
            int i, j;
            for (i = 0; i < tempt1.Length; i++)
            {
                t1s[i] = tempt1[i];
                for (j = 0; j < tempt2.Length; j++)
                {
                    t2s[i] = tempt2[i];
                }
            }

            t1s[t1s.Length - 1] = t1;
            t2s[t2s.Length - 1] = t2;

        }

    }
}
