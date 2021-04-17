using System;
using System.Collections.Generic;
using System.Text;


namespace BinaryTreeTraversalDemo
{
    class BinaryTree
    {
        private BinaryTreeNode root;


        public void Insert(int value)
        {
            var node = new BinaryTreeNode(value);

            //if the root is empty then insert value there
            if (root == null)
            {
                root = node;
                return;
            }

            // first assign root to a variable and keep changing thid variable with new node value as we traverse
            var current = root;

            // now traverse through the tree till be get to a point ot insert the value

            while (true)
            {
                if (value < current.Value)
                {
                    if (current.Left== null)
                    {
                        current.Left = node;
                        break;
                    }
                    current = current.Left;
                }
                else
                {
                    if (current.Right == null)
                    {
                        current.Right = node;
                        break;
                    }
                    current = current.Right;
                }
            }
        }


        public void PreOrderTraversal()
        {
            PreOrderTraversal(root);
        }

        private void PreOrderTraversal(BinaryTreeNode root)
        {
            if (root == null) return;

            Console.WriteLine(root.Value);
            PreOrderTraversal(root.Left);
            PreOrderTraversal(root.Right);
        }

        public void InOrderTraversalAsc()
        {
            InOrderTraversalAsc(root);
        }

        /// <summary>
        /// InOrder Traversal is used when you want to print the tree value in acsending order 
        /// that is Left Root Right
        /// </summary>
        /// <param name="root"></param>
        private void InOrderTraversalAsc(BinaryTreeNode root)
        {
            if (root == null) return;

            InOrderTraversalAsc(root.Left);
            Console.WriteLine(root.Value);
            InOrderTraversalAsc(root.Right);
        }


        public void InOrderTraversalDesc()
        {
            InOrderTraversalDesc(root);
        }

        /// <summary>
        /// InOrder Traversal is used when you want to print the tree value in acsending order 
        /// that is Left Root Right
        /// </summary>
        /// <param name="root"></param>
        private void InOrderTraversalDesc(BinaryTreeNode root)
        {
            if (root == null) return;

            InOrderTraversalDesc(root.Right);
            Console.WriteLine(root.Value);
            InOrderTraversalDesc(root.Left);
        }


        public void PostOrderTraversal()
        {
            PostOrderTraversal(root);
        }

        private void PostOrderTraversal(BinaryTreeNode root)
        {
            if (root == null) return;

            PostOrderTraversal(root.Left);
            PostOrderTraversal(root.Right);
            Console.WriteLine(root.Value);
        }
    }
}
