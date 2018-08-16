using System;
using System.Collections.Generic;
using System.Text;

namespace WeightedGraph
{
    class Edge : IComparable<Edge>
    {
        public string src;
        //public int id;
        public int weight;
        public string dest;
        public Edge(string src, int wt, string dest = "")
        {

            this.weight = wt;
            this.src = src;
            this.dest = dest;
        }
        public int CompareTo(Edge e)
        {
            if (this.weight < e.weight)
            {
                return -1;
            }
            return 1;
        }
    }
}
