using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        public int data;
        public Node left;
        public Node right;

        public Node(int value)
        {
            data = value;
            left = null;
            right = null;
        }

        public Node SetNode (Node node, int input)
        {
            if (node == null)
            {
                return node = new Node(input);
            }
            else if (node.data < input)
            {
                return SetNode(node.right, input);
            }
            else if (node.data > input)
            {
                return SetNode(node.left, input);
            }
            else
            {
                throw new System.ArgumentException("Whoops! You broke something....");
            }
        }


    }
}
