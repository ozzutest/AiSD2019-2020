using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    class Edge
    {
        public Item beginning;
        public Item end;
        public int weight = 1;

        public Edge(Item p, Item k, int weight = 1)
        {
            this.beginning = p;
            this.end = k;
            this.weight = weight;
        }

        public Item TakeSecond(Item w)
        {
            //  return (w == this.beginning) ? this.beginning : this.end;
            return (w == this.end) ? this.beginning : this.end;
        }

        public override string ToString() => $"{this.beginning} , {this.end}, {this.weight}";

    }
}
