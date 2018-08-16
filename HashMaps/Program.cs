using System;

namespace HashMaps
{
    class Program
    {
        static void Main(string[] args)
        {
            MyHashMap h = new MyHashMap();
            h.AddNewElement("abc", "123");
            h.AddNewElement("efg", "123");
            h.AddNewElement("hij", "123");
            h.AddNewElement("klm", "123");
            h.AddNewElement("abcx", "123");
            h.AddNewElement("efgx", "123");
            h.AddNewElement("hijx", "123");
            h.PrintTable();
            Console.ReadKey();
        }
    }
}
