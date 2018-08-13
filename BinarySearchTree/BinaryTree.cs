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
        public int count;
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

        public bool Search(int searchNum)
        {
            return root.Search(root, searchNum);
        }
    }
}
