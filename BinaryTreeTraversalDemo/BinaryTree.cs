using System;
using System.Collections.Generic;
using System.Text;


namespace BinaryTreeTraversalDemo
{
    class BinaryTree
    {
        private BinaryTreeNode root;
        IList<int> result = new List<int>();
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

        /// <summary>
        /// Linear find
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int FindLinear(int value)
        {
            var current = root;
            
            while (current != null)
            {
                if (current.Value == value) return value;
                if (value < current.Value)
                {
                    current = current.Left;
                }
                else if (value > current.Value)
                {
                    current = current.Right;
                }
            }

            return -1;            
        }

        /// <summary>
        /// Recursive Find
        /// </summary>
        /// <param name="value"></param>
        public bool FindRecursive(int value)
        {
            var current = root;
            if (current.Value == value) return true;
            if (value < current.Value)
            {
                current = current.Left;
                FindRecursive(current.Value);
            }
            else if (value > current.Value)
            {
                current = current.Right;
                FindRecursive(current.Value);
            }

            return false;
        }


        public void PreOrderTraversal()
        {
            PreOrderTraversal(root);
        }

        private void PreOrderTraversal(BinaryTreeNode root)
        {
            if (root == null) return;

            Console.WriteLine(" Root: "+ root.Value + " Left: " + root.Left + " Right: " + root.Right);
            PreOrderTraversal(root.Left);            
            PreOrderTraversal(root.Right);
        }

        public void InOrderTraversalAsc()
        {
            InOrderTraversalAsc(root);
        }

        /// <summary>
        /// InOrder Traversal is used when you want to print the tree value in acsending or Descending order 
        /// For ascending  the rule Left Root Right
        /// </summary>
        /// <param name="root"></param>
        private void InOrderTraversalAsc(BinaryTreeNode root)
        {
            if (root == null) return;


            InOrderTraversalAsc(root.Left);                 
            Console.WriteLine(" Root: " + root.Value + " Left: " + root.Left + " Right: " + root.Right);
            InOrderTraversalAsc(root.Right);            
        }

        public void InOrderTraversalDesc()
        {
            InOrderTraversalDesc(root);
        }

        /// <summary>
        /// InOrder Traversal is used when you want to print the tree value in acsending or Descending order 
        /// For Descending  the rule Left Root Right
        /// </summary>
        /// <param name="root"></param>
        private void InOrderTraversalDesc(BinaryTreeNode root)
        {
            if (root == null) return;

            InOrderTraversalDesc(root.Right);
            Console.WriteLine(" Root: " + root.Value + " Left: " + root.Left + " Right: " + root.Right);
            InOrderTraversalDesc(root.Left);
        }

        public IList<int> InOrderTraversalListAsc()
        {
            return InOrderTraversalListAsc(root);
        }

        private IList<int> InOrderTraversalListAsc(BinaryTreeNode root)
        {
           

            if (root == null) return result;
            if (root.Left != null)
                InOrderTraversalListAsc(root.Left);

            result.Add(root.Value);

            if (root.Right != null)
                InOrderTraversalListAsc(root.Right);

            return result;
        }

        public IList<int> InOrderTraversalListAsc1()
        {
            return InOrderTraversalListAsc1(root);
        }



        private IList<int> InOrderTraversalListAsc1(BinaryTreeNode root)
        {
            IList<int> res = new List<int>();
            helper(root, res);
            return res;
        }

        private void helper(BinaryTreeNode root, IList<int> res)
        {
            if (root != null)
            {
                if (root.Left != null)
                    helper(root.Left, res);

                res.Add(root.Value);

                if (root.Right != null)
                    helper(root.Right, res);
            }
        }


        public void PostOrderTraversal()
        {
            PostOrderTraversal(root);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        private void PostOrderTraversal(BinaryTreeNode root)
        {
            if (root == null) return;

            PostOrderTraversal(root.Left);
            PostOrderTraversal(root.Right);
            Console.WriteLine(" Left: " + root.Left + " Right: " + root.Right + " Root: " + root.Value);
        }

        public int HeightofTree()
        {
            return HeightofTree(root);
        }

        private int HeightofTree(BinaryTreeNode root)
        {
            if (root.Left == null && root.Right == null) return 0;

            return 1 + Math.Max(
                HeightofTree(root.Left), 
                HeightofTree(root.Right)
                );            
        }
    }
}
