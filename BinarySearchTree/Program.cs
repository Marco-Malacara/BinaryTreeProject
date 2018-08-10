using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree node = new BinaryTree();

            node.Add(node, 12);
            Console.WriteLine(node);
            Console.ReadLine();
        }
    }
}
