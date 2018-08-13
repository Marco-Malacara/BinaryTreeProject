using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinaryTree
    {
        Node rootNode = new Node();
        public BinaryTree()
        {
           
        }

        public void Add(Node node, int input)
        {
            if (node = 0)
            {
                node = new BinaryTree();
                node.value = input;
            }
        }
    }
}
