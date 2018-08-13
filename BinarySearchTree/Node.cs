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
                if(node.right == null)
                {
                    node.right = new Node(input);
                    return node.right;
                }
                else
                {
                    return SetNode(node.right, input);
                }
                
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

        public bool Search(Node node, int numSearch)
        {
            if (node == null)
            {
                return false;
            }
            else if (node.data == numSearch)
            {
                Console.WriteLine("Your number was found!");
                Console.WriteLine(node.data);
                return true;
            }
            else if (node.data < numSearch)
            {
                return Search(node.right, numSearch);
            }
            else if (node.data > numSearch)
            {
                return Search(node.left, numSearch);
            }
            else
            {
                throw new System.ArgumentException("That item is not in this tree!");
            }
        }
    }
}
