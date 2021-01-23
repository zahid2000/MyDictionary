using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Yusif");
            myDictionary.Add(2, "Zahid");
            myDictionary.Add(3, "Inci");

            myDictionary.View();
        }
    }
}
