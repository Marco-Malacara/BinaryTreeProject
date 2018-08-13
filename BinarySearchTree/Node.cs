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
            data = 0;
            left = null;
            right = null;
        }

        public void InputData(Node node, int input)
        {
            if (node == null)
            {
                node = new Node(input);
            }
            else if (node.data < input)
            {
                
            }
        }
    }
}
