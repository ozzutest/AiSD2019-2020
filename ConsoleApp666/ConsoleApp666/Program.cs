using System;
using System.Collections.Generic;
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
            //Tree.Item i1 = new Item(5);
            //Item i2 = new Item(6);
            //List<Item> list = new List<Item>() { i1, i2 };

            //Console.WriteLine(list.Contains(i1));/sprawdzenie czy wezel jest odwiedzony
            //Console.WriteLine(list.Contains(i2));

            var a = new Item(1);
            var b = new Item(2);
            var c = new Item(3);
            var d = new Item(4);
            var e = new Item(5);
            var f = new Item(6);
            var g = new Item(7);
            

            var graph = new Graph();

            graph.Add(a, b);
            graph.Add(a, c);
            graph.Add(a, d);
            graph.Add(b, e);
            graph.Add(c, f);
            graph.Add(e, g);

            foreach (var node in graph.SearchGraphDepth(a)) 
                Console.WriteLine(node);

            Console.ReadKey();
        }
    }
}
