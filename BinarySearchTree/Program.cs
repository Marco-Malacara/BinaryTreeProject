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
            BinaryTree tree = new BinaryTree();

            tree.Add(12);
            tree.Add(14);
            tree.Add(11);
            tree.Add(1);
            Console.WriteLine(tree.count);
            Console.ReadLine();
        }
    }
}
