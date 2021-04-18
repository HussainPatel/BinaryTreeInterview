using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeDemo
{
    public class Node
    {
        public int Value;
        public Node(int value)
        {
            this.Value = value;
        }

        public Node Left;

        public Node Right;

        public override string ToString()
        {
            return "Node Value: " + Value;
        }
    }
}
