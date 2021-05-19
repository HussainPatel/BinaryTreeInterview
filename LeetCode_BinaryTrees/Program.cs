using System;
using System.Collections.Generic;

namespace LeetCode_BinaryTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            BinaryTree binaryTree = new BinaryTree();

            // Insert a node            
            binaryTree.Insert(7);
            binaryTree.Insert(4);
            binaryTree.Insert(9);
            binaryTree.Insert(1);
            binaryTree.Insert(6);
            binaryTree.Insert(8);
            binaryTree.Insert(10);

            var preOderTravesalList = binaryTree.PreorderTraversal();

            foreach (var i in preOderTravesalList)
                Console.Write("{0}, ", i);


            Console.Read();
        }
    }

    public class BinaryTree
    {
        public TreeNode root;


        #region "Insert key into the binary tree" 
        /*
       * Given a binary tree and a key, insert the key into the binary tree at the first position available in
       * Algorithm
       * create a method with 1 parameter for ket to insert in binary tree
       *  first check the Root is null - if yes create a new node and assign the key / value and return and not go in loop
       * create a local variable and assign root to current
       * next use loop while true - we need to create a node either left or right and assign a value
       * To chekc which wayto go - chekc the value with current value
       * if value < current.value - go left and if left is null create a new node and add value and break to end the while loop
       * if not null - further move the the current.leftNode to current
       * if value > current.value - go right and if right is null create a new node and add value and break;
       * if not null - further move the the current.leftNode to current
       */
        public void Insert(int value)
        {
            if (root == null)
            {
                root = new TreeNode(value);
                return;
            }

            var current = root;

            while (true)
            {
                if (value < current.value)
                {
                    if (current.leftChild == null)
                    {
                        current.leftChild = new TreeNode(value);
                        break;
                    }
                    current = current.leftChild;
                }
                else
                {
                    if (value > current.value)
                    {
                        if (current.rightChild == null)
                        {
                            current.rightChild = new TreeNode(value);
                            break;
                        }

                        current = current.rightChild;
                    }
                }
            }
        }

        #endregion

        #region"Binary Tree PreOrder Traversal - Using Recursion"

        public IList<int> PreorderTraversal() => PreorderTraversal(root);

        private IList<int> PreorderTraversal(TreeNode root)
        {
            List<int> result = new List<int>();
            PreOrderHelper(root, result);
            return result;
        }

        private void PreOrderHelper(TreeNode root, List<int> result)
        {
            if (root != null)
            {
                result.Add(root.value);

                if (root.leftChild != null)
                    PreOrderHelper(root.leftChild, result);

                if (root.rightChild != null)
                    PreOrderHelper(root.rightChild, result);
            }
        }
        #endregion

        #region"Binary Tree InOrder Traversal - Using Recursion"

        /*
         * Algorithm
         * 
         */

        public void InOrderTraversal() => InOrderTraversal(root);

        private IList<int> InOrderTraversal(TreeNode root)
        {
            IList<int> result = new List<int>();
            InOrderHelper(root, result);
            return result;
           
        }

        private void InOrderHelper(TreeNode root, IList<int> result)
        {
            if (root != null)
            {
                if (root.leftChild != null)
                    InOrderHelper(root.leftChild, result);
                result.Add(root.value);
                if (root.rightChild != null)
                    InOrderHelper(root.rightChild, result);
            }

        }


        #endregion
    }

    public class TreeNode
    {
        public int value;
        public TreeNode leftChild;
        public TreeNode rightChild;

        public TreeNode(int val=0,TreeNode left =null, TreeNode right=null)
        {
            value = val;
            leftChild = left;
            rightChild = right;

        }     
          
    }
}
