using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinaryTree
    {
        Node root;
        int count;
        public BinaryTree()
        {
            root = null;
            count = 0;
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
                root.SetNode(root, num);
            }
            count++;
        }
        public void DisplayTree(Node d)
        {
            if (d == null)
            {
                return;
            }
            DisplayTree(root.left);
            DisplayTree(root.right);
        }

    }
}
