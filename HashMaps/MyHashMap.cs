using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace HashMaps
{
    class MyHashMap
    {
        int Capacity;
        int NoOfItems;
        List<LinkedList<Element>> Table;
        static int PRIME;

        public MyHashMap()
        {
            PRIME = 7;
            NoOfItems = 0;
            Capacity = PRIME;
            Table = new List<LinkedList<Element>>(Capacity);
            createLinkedLists();
        }
        void createLinkedLists()
        {
            for (int i = 0; i < Capacity; i++)
            {
                Table.Add(new LinkedList<Element>());
            }
        }
        public void AddNewElement(string key, string value)
        {
            Element newElement = new Element(key, value);
            InsertIntoTable(newElement);
            ++NoOfItems;
            if (LoadFactor() > 0.7)
            {
                Rehash();
            }
        }
        void Rehash()
        {
            List<LinkedList<Element>> oldTable = Table;
            int oldCapacity = Capacity;
            Capacity = Capacity * 2;
            Table = new List<LinkedList<Element>>();
            createLinkedLists();
            for(int i = 0; i < oldCapacity; i++)
            {
                var item = oldTable[i];
                while (item.Count != 0)
                {
                    Element currentElemenet = item.ElementAt(0);
                    item.RemoveFirst();
                    InsertIntoTable(currentElemenet);
                }
            }


        }
        void InsertIntoTable(Element elementToAdd)
        {
            int index = FindIndex(elementToAdd.key);
            LinkedList<Element> ListOfKey = Table[index];
            ListOfKey.AddFirst(elementToAdd);
        }
        double LoadFactor()
        {
            return NoOfItems / Capacity;
        }
        int FindIndex(string key)
        {
            int mul = 1;
            int ans = 0;
            for (int i = 0; i < key.Length; i++)
            {
                char currentCharacter = key[i];
                int charIn27base = currentCharacter - 'a';
                int curterm = (charIn27base % Capacity) * (mul % Capacity) % Capacity;
                ans += curterm;
                ans = ans % Capacity;
            }
            return ans;
        }
        public void PrintTable()
        {
            for (int i = 0; i < Capacity; i++)
            {
                Console.WriteLine();
                foreach (Element ele in Table[i])
                {
                    Console.Write(ele.key + "(" + ele.value + ")->" + "  ");
                }
            }
        }
    }
}
