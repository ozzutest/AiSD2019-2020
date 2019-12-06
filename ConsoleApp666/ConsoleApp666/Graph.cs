using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tree
{
    class Graph
    {
        public List<Item> nodes;
        public List<Edge> edges;

        public Graph()
        {
            this.nodes = new List<Item>();
            this.edges = new List<Edge>(); 
        }

        public void Add(Item node)
        {
            this.nodes.Add(node);
        }

        public void Add(Item p, Item k, int weight = 1)
        {
            var edge = new Edge(p, k, weight);

            if (!this.edges.Contains(edge))
                this.edges.Add(edge);
            
        }

        public List<Edge> TakeEdges(Item node)
        {
            return this.edges.Where(k => k.beginning == node || k.end == node).ToList();
        }

        public void Push()
        {

        }
        
        public List<Item> SearchGraphDepth(Item start)
        {
            var  discoveredNodes = new List<Item>();
            var stack = new Stack<Item>();
            stack.Push(start);

            while (stack.Count > 0)
            {
                var node = stack.Pop();

                if (discoveredNodes.Contains(node))
                    continue;

                discoveredNodes.Add(node);

                foreach (var edge in this.TakeEdges(node).OrderByDescending(x => x.TakeSecond(node).value))
                {
                    var second = edge.TakeSecond(node);

                    if (!discoveredNodes.Contains(second))
                        stack.Push(second);
                }
            }
            return discoveredNodes;
        }
    }
}
