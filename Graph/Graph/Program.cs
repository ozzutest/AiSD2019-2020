using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using Tree;

namespace ConsoleApp666
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = new Node(1);
            var b = new Node(2);
            var c = new Node(3);
            var d = new Node(4);
            var e = new Node(5);
            var f = new Node(6);
            var g = new Node(7);

            var graph = new Graph();

            graph.Add(a, b);
            graph.Add(a, c);
            graph.Add(a, d);
            graph.Add(b, e);
            graph.Add(c, f);
            graph.Add(e, g);

            foreach (var node in graph.BreadthFirstSearch(a))
                Console.WriteLine($"BFS: {node}");

            graph.Add(a);
            graph.Add(b);
            graph.Add(c);
            graph.Add(d);
            graph.Add(e);
            graph.Add(f);
            graph.Add(g);

            Console.WriteLine($"\nDFS:\n");

            graph.DepthFirstSearch(a);

            Console.ReadKey();
        }
    }
}