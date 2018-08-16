using System;
using System.Collections.Generic;
using System.Linq;

namespace WeightedGraph
{
    class Program
    {
        static public Dictionary<string, int> Dijkstra(Graph<String, int> g, string src)
        {
            PriorityQueue<Edge> pq = new PriorityQueue<Edge>();
            Dictionary<string, int> distFromSource = new Dictionary<string, int>();
            HashSet<string> visited = new HashSet<string>();

            pq.Push(new Edge(src, 0));

            while (pq.Count() != 0)
            {
                Edge currentEdge = pq.Top();
                pq.Pop();
                if (visited.Contains(currentEdge.src))
                {
                    continue;
                }
                visited.Add(currentEdge.src);
                distFromSource.Add(currentEdge.src, currentEdge.weight);
                var neighbours = g.AdjList[currentEdge.src];
                for (int i = 0; i < neighbours.Count; i++)
                {
                    if (visited.Contains(neighbours.ElementAt(i).Item1) == false)
                    {
                        int wt = neighbours.ElementAt(i).Item2 + distFromSource[currentEdge.src];
                        pq.Push(new Edge(neighbours.ElementAt(i).Item1, wt));
                    }
                }

            }
            return distFromSource;
        }
        static void Main(string[] args)
        {
            Graph<string, int> g = new Graph<string, int>(3);
            g.AddEdge("A", "B", 5);
            g.AddEdge("A", "C", 10);
            g.AddEdge("B", "C", 3);
            g.PrintGraph();
            var distfromSrc = Dijkstra(g, "A");
            for (int i = 0; i < distfromSrc.Count; i++)
            {
                Console.WriteLine("-> " + distfromSrc.ElementAt(i).Value);
            }

            Console.ReadKey();


        }
    }
}
