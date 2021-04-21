using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeTraversalDemo
{
    class BinaryTreeNode
    {
        public BinaryTreeNode(int value)
        {
            this.Value = value;
        }

        public int Value;
        public BinaryTreeNode Left;
        public BinaryTreeNode Right;

        public override string ToString()
        {
            return ": " + Value;
        }
    }
}
