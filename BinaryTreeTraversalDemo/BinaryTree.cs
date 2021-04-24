using System;
using System.Collections.Generic;
using System.Text;


namespace BinaryTreeTraversalDemo
{
    class BinaryTree
    {
        private BinaryTreeNode root;
        IList<int> result = new List<int>();

        #region "Insert/Add value in a Binary Tree"
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
                    if (current.Left == null)
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
        #endregion

        #region "Find value in a Binary Tree - Linear and Recursive"
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
        #endregion 

        #region "Tree Traversal - PreOrder , InOrder and PostOrder"
        public void PreOrderTraversal() => PreOrderTraversal(root);

        private void PreOrderTraversal(BinaryTreeNode root)
        {
            if (root == null) return;

            Console.WriteLine(" Root: " + root.Value + " Left: " + root.Left + " Right: " + root.Right);
            PreOrderTraversal(root.Left);
            PreOrderTraversal(root.Right);
        }

        public void InOrderTraversalAsc() => InOrderTraversalAsc(root);

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

        public void InOrderTraversalDesc() => InOrderTraversalDesc(root);

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

        public IList<int> InOrderTraversalListAsc() => InOrderTraversalListAsc(root);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IList<int> InOrderTraversalListAsc1() => InOrderTraversalListAsc1(root);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        private IList<int> InOrderTraversalListAsc1(BinaryTreeNode root)
        {
            IList<int> res = new List<int>();
            helper(root, res);
            return res;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        /// <param name="res"></param>
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

        /// <summary>
        /// 
        /// </summary>
        public void PostOrderTraversal() => PostOrderTraversal(root);

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
        #endregion

        #region "Find Height of a Binary Tree"

        /* Algorithm
         * 
         * 
        */
        public int HeightofTree() => HeightofTree(root);

        /// <summary>
        /// Height of the Tree.
        /// </summary>
        /// <param name="root"> Pass root as parameter</param>
        /// <returns> Add 1 for root to get height of the tree</returns>
        private int HeightofTree(BinaryTreeNode root)
        {
            if (root == null) return -1;

            if (IsLeaf(root)) return 0;

            return 1 + Math.Max(HeightofTree(root.Left), HeightofTree(root.Right));
        }
        #endregion

        #region "Find maximum (or minimum) in Binary Tree"        
        //Question: Given a Binary Tree, find the maximum(or minimum) element in it

        /* In Binary Search Tree, we can find maximum by traversing right pointers until we reach the rightmost node. 
         * But in Binary Tree, we must visit every node to figure out maximum. So the idea is to traverse the given tree and for every node return maximum of 3 values. 
         * Algorithm 
         *  Node’s data.
         *  Maximum in node’s left subtree.
         *  Maximum in node’s right subtree.        
         *  Math.Max of left, right, root
         */

        public int MaximumValue() => MaximumValue(root);

        private int MaximumValue(BinaryTreeNode root)
        {
            if (IsLeaf(root)) return root.Value;

            var left = MaximumValue(root.Left);
            var right = MaximumValue(root.Right);

            return Math.Max(Math.Max(left, right), root.Value);
        }

        /*
        * In Binary Search Tree, we can find maximum by traversing left pointers until we reach the leftmost node. 
        * But in Binary Tree, we must visit every node to figure out minimum. So the idea is to traverse the given tree and for every node return minimum of 3 values (left, right, root). 
        * Algorithm 
        *  Node’s data.
        *  Minimum in node’s left subtree.
        *  Minimum in node’s right subtree. 
        *  Math.Min of left, right, root
        */

        public int MinimumValue() => MinimumValue(root);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        private int MinimumValue(BinaryTreeNode root)
        {
            if (IsLeaf(root)) return root.Value;

            var left = MinimumValue(root.Left);
            var right = MinimumValue(root.Right);

            return Math.Min(root.Value, Math.Min(left, right));
        }

        private bool IsLeaf(BinaryTreeNode node)
        {
            return node.Left == null && node.Right == null;
        }


        /* 
         * Complexity Analysis:
         * Time Complexity : O(N).
         *      In the recursive function calls, every node of the tree is processed once and hence the complexity due to the function is O(N)
         *      if there are total N nodes in the tree. Therefore, the time complexity is O(N).
         * Auxiliary Space : O(1).
         *      Any extra space is not required, so the space complexity is constant.
         */

        #endregion

        #region "Find maximum (or minimum) in Binary Search Tree"

        /* Find the node with Maximum value in a Binary Search Tree
         * This is quite simple. Just traverse the node from root to Right recursively until right is NULL. 
         * The node whose right is NULL is the node with maximum value.
         * For More info on Binary Search Tree - http://cslibrary.stanford.edu/110/BinaryTrees.html
         */
        public int BSTMaximumValue() => BSTMaximumValue(root);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        private int BSTMaximumValue(BinaryTreeNode root)
        {
            // if tree is empty - handle the base case.
            if (root == null)
            {
                throw new NullReferenceException();
            }
            var current = root;
            var last = current;
            while (current != null)
            {
                last = current;
                current = current.Right;
            }

            return last.Value;
        }

        /* 
        * Find the node with Maximum value in a Binary Search Tree
        * This is quite simple. Just traverse the node from root to left recursively until left is NULL. 
        * The node whose left is NULL is the node with minimum value.
        * For More info on Binary Search Tree - http://cslibrary.stanford.edu/110/BinaryTrees.html
        */
        // Minimum value in a Binary Search tree.
        public int BSTMinimumValue() => BSMinimumValue(root);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        private int BSMinimumValue(BinaryTreeNode root)
        {
            //if tree is empty - we handle the base case - check the null and throw null reference exception
            if (root == null)
            {
                throw new NullReferenceException();
            }

            var current = root;
            var last = current;
            while (current != null)
            {
                last = current;
                current = current.Left;
            }

            return last.Value;
        }

        /*
         * Time Complexity: O(n) Worst case happens for left skewed trees.
         */
        #endregion

        #region "Check two binary trees for equality"
        /*
         *  E
         */
        public bool Equality(BinaryTree other)
        {
            if (other == null) throw new NullReferenceException();

            return Equality(root, other.root);
        }

        private bool Equality(BinaryTreeNode root1, BinaryTreeNode root2)
        {
            if (root1 == null && root2 == null) return true;
            if (root1 != null && root2 != null)
                return root1.Value == root2.Value
                    && Equality(root1.Left, root2.Left) && Equality(root1.Right, root2.Right);

            return false;

        }

        #endregion
    }
}
