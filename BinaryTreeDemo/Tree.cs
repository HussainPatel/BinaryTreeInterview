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

    }
}
