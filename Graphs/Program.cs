using System;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Graph g = new Graph(4);
            //g.AddEdge("A", "B");
            //g.AddEdge("B", "C");
            //g.AddEdge("C", "A");
            //g.AddEdge("A", "D");
            //g.AddEdge("D", "B");

            Graph g = new Graph(7);
            g.AddEdge("A", "B");
            g.AddEdge("A", "C");
            g.AddEdge("B", "D");
            g.AddEdge("B", "F");
            g.AddEdge("C", "G");
            g.AddEdge("C", "E");
           // g.AddEdge("A", "F");


            g.PrintGraph();
            Console.Write(g.FindCycle());
            //g.dfs("A");
            //g.bfs("A");
            Console.ReadKey();
        }
    }
}
