using System;
using System.Collections.Generic;


namespace GDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> NameAge = new MyDictionary<string, int>();

            NameAge.Add("Zehra",19);
            NameAge.Add("Zeynep",4);
            

        }
    }
}

