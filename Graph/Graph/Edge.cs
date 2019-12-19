using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    class Edge
    {
        public Node beginning;
        public Node end;
        public int weight = 1;

        public Edge(Node p, Node k, int weight = 1)
        {
            this.beginning = p;
            this.end = k;
            this.weight = weight;
        }

        public Node TakeSecond(Node w) => (w == this.end) ? this.beginning : this.end;


        public override string ToString() => $"{this.beginning} , {this.end}, {this.weight}";

    }
}