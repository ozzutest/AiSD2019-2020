using System;
using TreeClass;
namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new TreeClass.Tree(9);
            
            for (int i = 0; i < 9; i++)
                tree.Push(i);
            
            Console.WriteLine(tree);
            Console.WriteLine($"Length of tree: {tree.length}, depth of three: {tree.depth}, Root: {tree.FindParent(12)}");
            Console.ReadKey();

        }
    }
}
