using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeDemo
{
    /// <summary>
    ///pseudocode for binarytree
    ///create a Tree class
    ///create private class Node inside tree class
    /// Node (value , leftChild, rightChild)
    ///root field
    /// insert(value)
    ///find(value): boolean
    /// </summary>
    public class Tree
    {
        private Node root;

        // Hint - for insert and Find - first you need ot find a node - for inserting a value , we need to find where in the tree we need to insert a value 
        // to find a value - we nned to use the look up algorithm - we need to start from root node 
        // so have a variable - current node  that is equat to value of root.
        // next loop through all the values using while true 
        //if the value to find is snaaller than the current node traverse left else if it is greater traverse to the right..
        /// <summary>
        /// Hint - for insert and Find - first you need ot find a node - for inserting a value , we need to find where in the tree we need to insert a value 
        /// to find a value - we nned to use the look up algorithm - we need to start from root node 
        /// so have a variable - current node  that is equat to value of root.
        /// next loop through all the values using while true 
        /// if the value to find is snaaller than the current node traverse left else if it is greater traverse to the right..
        /// </summary>
        /// <param name="value"></param>
        public void Insert(int value)
        {
            var node = new Node(value);

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
        
        public bool Find(int value)
        {
            // we need to traverse the tree from root to the leaf node
            var current = root;
            while (current != null)
            {
                if (current.Value == value) return true;
                if (value < current.Value)
                {
                    current = current.Left;
                }
                else if (value > current.Value)
                {
                    current = current.Right;
                }
            }

            return false;
           
        }

        public void PreOrderTraversal() => PreOrderTraversal(root);

        private void PreOrderTraversal(Node root)
        {
            if (root == null) return;

            Console.Write(root.Value + " ");
            PreOrderTraversal(root.Left);
            PreOrderTraversal(root.Right);
        }

        public bool Delete(int e)
        {
            var p = root;
            Node pp = null;
            while (p != null && p.Value != e)
            {
                pp = p;
                if (e < p.Value)
                    p = p.Left;
                else if (e > p.Value)
                    p = p.Right;
            }

            if (p == null) return false;

            // handle third case 
            if (p.Left != null && p.Right != null)
            {
                Node s = p.Left; // we can choose the largest from left or smallest from the right sub tree
                Node ps = p;
                while (s.Right != null)
                {
                    ps = s;
                    s = s.Right;
                }
                p.Value = s.Value;
                p = s;
                pp = ps;
            }

            // handle second case
            Node c = null;
            if (p.Left != null)
                c = p.Left;
            else
                c = p.Right;


            if (p == root)
                root = null;
            else
            {
                if (p == pp.Left)
                    pp.Left = c;
                else
                    pp.Right = c;
            }

            return true;
        }
    }
}
