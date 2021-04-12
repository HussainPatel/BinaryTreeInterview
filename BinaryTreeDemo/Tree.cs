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

        private class Node
        {
            public Node(int value)
            {
                this.value = value;
            }

            public int value;
            public Node leftChild;
            public Node rightChild;

            public override string ToString()
            {
                return "Node: " + value;
            }
        }


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
                if (value < current.value)
                {
                    if (current.leftChild == null)
                    {
                        current.leftChild = node;
                        break;
                    }
                    current = current.leftChild;
                }
                else
                {
                    if (current.rightChild == null)
                    {
                        current.rightChild = node;
                        break;
                    }
                    current = current.rightChild;
                }
            }
        }
        
        public bool Find(int value)
        {
            // we need to traverse the tree from root to the leaf node
            var current = root;
            while (current != null)
            {
                if (current.value == value) return true;
                if (value < current.value)
                {
                    current = current.leftChild;
                }
                else if (value > current.value)
                {
                    current = current.rightChild;
                }
            }

            return false;
           
        }

    }
}
