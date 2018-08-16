using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace WeightedGraph
{
    class Graph<T, K>
    {
        public int NumberOfVertices { get; private set; }
        public Dictionary<T, List<Tuple<T, K>>> AdjList { private set; get; }

        public Graph(int vertices)
        {
            this.NumberOfVertices = vertices;
            AdjList = new Dictionary<T, List<Tuple<T, K>>>();
        }
        public void AddEdge(T src, T dest, K wt)
        {
            if (AdjList.ContainsKey(src) == false)
            {
                AdjList.Add(src, new List<Tuple<T, K>>());
            }
            if (AdjList.ContainsKey(dest) == false)
            {
                AdjList.Add(dest, new List<Tuple<T, K>>());
            }
            AdjList[src].Add(new Tuple<T, K>(dest, wt));
            AdjList[dest].Add(new Tuple<T, K>(src, wt));
        }
        public void PrintGraph()
        {
            for (int i = 0; i < AdjList.Count; i++)
            {
                var currentList = AdjList.ElementAt(i);
                for (int j = 0; j < currentList.Value.Count; j++)
                {
                    Console.WriteLine(" " + currentList.Key + currentList.Value.ElementAt(j));
                }

            }
        }


    }
}



