using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace Tree
{
    class Graph
    {
        public List<Node> nodes;
        public List<Edge> edges;
        public List<Node> DiscoveredNodesList;
        public Graph()
        {
            this.nodes = new List<Node>();
            this.edges = new List<Edge>();
        }

        public void Add(Node node)
        {
            this.nodes.Add(node);
        }

        public void Add(Node p, Node k, int weight = 1)
        {
            var edge = new Edge(p, k, weight);

            if (!this.edges.Contains(edge))
                this.edges.Add(edge);

        }

        public List<Edge> TakeEdges(Node node) => this.edges.Where(k => k.beginning == node || k.end == node).ToList();

        public void DFS(Node node)
        {
            if (this.DiscoveredNodesList.Contains(node)) return;

            this.DiscoveredNodesList.Add(node);

            foreach (var edge in this.TakeEdges(node))
                this.DFS(edge.TakeSecond(node));

        }

        public void DepthFirstSearch(Node start)
        {
            this.DiscoveredNodesList = new List<Node>();

            this.DFS(start);

            foreach (var node in this.DiscoveredNodesList)
                Console.WriteLine(node);
        }

        //BFS

        public List<Node> BreadthFirstSearch(Node start)
        {
            var discoveredNodes = new List<Node>();
            var stack = new Stack<Node>();
            stack.Push(start);

            while (stack.Count > 0)
            {
                var v = stack.Pop();

                if (discoveredNodes.Contains(v))
                    continue;

                discoveredNodes.Add(v);

                var takeEdges = this.TakeEdges(v);

                for (int i = takeEdges.Count - 1; i >= 0; i--)
                {
                    Node SecondNodeFromEdge = takeEdges[i].TakeSecond(v);
                    if (!discoveredNodes.Contains(SecondNodeFromEdge))
                        stack.Push(SecondNodeFromEdge);
                }

            }

            return discoveredNodes;
        }
    }
}
