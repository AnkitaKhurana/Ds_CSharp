using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Graphs
{
    class Graph
    {
        int NoOfVertices;
        Dictionary<string, List<string>> AdjacencyList;

        public Graph(int vertex)
        {
            this.NoOfVertices = vertex;
            AdjacencyList = new Dictionary<string, List<string>>();
        }
        public void AddEdge(string src, string des)
        {
            if (AdjacencyList.ContainsKey(src) == false)
            {
                AdjacencyList.Add(src, new List<string>());
            }
            if (AdjacencyList.ContainsKey(des) == false)
            {
                AdjacencyList.Add(des, new List<string>());
            }
            AdjacencyList[src].Add(des);
            // Here Undirected graph therefore adding des to src too
            AdjacencyList[des].Add(src);
        }
        public void dfs(string src)
        {
            HashSet<string> visitedElemenets = new HashSet<string>();
            dfs(src, visitedElemenets);
        }
        private void dfs(string src, HashSet<string> visited)
        {
            visited.Add(src);
            if (AdjacencyList.ContainsKey(src) == false)
            {
                return;
            }
            Console.WriteLine(src + " ");
            var currentList = AdjacencyList[src];
            for (int i = 0; i < currentList.Count; i++)
            {
                if (visited.Contains(currentList[i]) == false)
                {
                    dfs(currentList[i], visited);
                }
            }
        }
        public void bfs(string src)
        {
            HashSet<string> visitedElemenets = new HashSet<string>();
            Queue<string> q = new Queue<string>();
            q.Enqueue(src);
            bfs(visitedElemenets, q);
        }
        private bool FindCycle(string src, HashSet<string> visted, string parent)
        {
            visted.Add(src);
            var currentList = AdjacencyList[src];
            for (int i = 0; i < currentList.Count; i++)
            {
                if (visted.Contains(currentList.ElementAt(i)) == false)
                {
                    visted.Add(currentList.ElementAt(i));
                    parent = src;
                    FindCycle(currentList.ElementAt(i), visted, parent);
                 
                }
                else
                {
                    if (parent != currentList.ElementAt(i))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool FindCycle()
        {
            string src = AdjacencyList.ElementAt(0).Key;
            HashSet<string> visited = new HashSet<string>();
            return FindCycle(src, visited, src);

        }
        private void bfs(HashSet<string> visited, Queue<string> q)
        {
            if (q.Count != 0)
            {
                string currentElement = q.Dequeue();
                visited.Add(currentElement);
                var currentList = AdjacencyList[currentElement];
                for (int i = 0; i < currentList.Count; i++)
                {
                    if (visited.Contains(currentList.ElementAt(i)) == false)
                    {
                        q.Enqueue(currentList.ElementAt(i));
                        visited.Add(currentList.ElementAt(i));
                    }
                }
                Console.WriteLine(currentElement);
                bfs(visited, q);
            }
        }
        public void PrintGraph()
        {
            for (int i = 0; i < AdjacencyList.Count; i++)
            {
                var pairs = AdjacencyList.ElementAt(i);
                Console.Write(pairs.Key + "( ");
                for (int pair = 0; pair < pairs.Value.Count; pair++)
                {
                    Console.Write(" " + pairs.Value.ElementAt(pair));
                }
                Console.WriteLine(" )");
            }
        }

    }
}
