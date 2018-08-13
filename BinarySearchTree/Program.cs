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

            tree.Add(50);
            tree.Add(100);
            tree.Add(25);
            tree.Add(35);
            tree.Add(45);
            tree.Add(95);
            tree.Add(65);
            tree.Add(75);
            //tree.Search(45);
            Console.WriteLine(tree.Search(25));
            Console.ReadLine();
        }
    }
}
