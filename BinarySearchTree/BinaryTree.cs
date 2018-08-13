using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinaryTree
    {
        public Node root;
        private int movedLeft;
        private int movedRight;

        public BinaryTree()
        {
            root = null;
            movedLeft = 0;
            movedRight = 0;
        }

        public bool IsEmpty()
        {
            return root == null;
        }

        public void Add(int num)
        {
            if (IsEmpty())
            {
                root = new Node(num);
            }
            else
            {
                SetNode(root, num);
            }
        }

        public Node SetNode(Node node, int input)
        {
            if (node == null)
            {
                return node = new Node(input);
            }
            else if (node.data < input)
            {
                if (node.right == null)
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
                if (node.left == null)
                {
                    node.left = new Node(input);
                    return node.left;
                }
                else
                {
                    return SetNode(node.left, input);
                }
            }
            else
            {
                throw new ArgumentException("Whoops! You broke something....");
            }
        }

        public bool Search(int searchNum)
        {
            return Search(root, searchNum);
        }

        public bool Search(Node node, int numSearch)
        {
            if (node == null)
            {
                return false;
            }
            else if (node.data == numSearch)
            {
                Console.WriteLine("Your search number " + node.data + " was found!");
                Console.WriteLine("It was " + movedLeft + " to the left" + " and " + movedRight + " to the right!");
                return true;
            }
            else if (node.data < numSearch)
            {
                movedRight++;
                return Search(node.right, numSearch);
            }
            else if (node.data > numSearch)
            {
                movedLeft++;
                return Search(node.left, numSearch);
            }
            else
            {
                throw new ArgumentException("That item is not in this tree!");
            }
        }
    }
}
