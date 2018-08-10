using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinaryTree
    {
        private int data;
        private int root;
        private int value;
        private BinaryTree left;
        private BinaryTree right;

        public BinaryTree()
        {
            data = 0;
            root = 0;
            value = 0;
            left = null;
            right = null;
        }

        public void Add(BinaryTree node, int input)
        {
            if (node.value == 0)
            {
                node = new BinaryTree();
                node.value = input;
            }
        }
    }
}
