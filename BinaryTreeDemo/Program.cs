using System;

namespace BinaryTreeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // pseudocode for binarytree
            //create a Tree class
            //create private class Node inside tree class
            // Node (value , leftChild, rightChild)
            // root field
            // insert(value)
            //find(value): boolean

            Tree tree = new Tree();

            tree.Insert(7);           
            tree.Insert(4);            
            tree.Insert(9);            
            tree.Insert(1);            
            tree.Insert(6);            
            tree.Insert(8);            
            tree.Insert(10);
            //var result = tree.Find(7);
            //var result = tree.Find(11);
            var result = tree.FindRecursive(6);

            Console.WriteLine(result);

            Console.Read();
        }
    }
}
