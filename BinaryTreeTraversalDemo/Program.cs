using System;

namespace BinaryTreeTraversalDemo
{
    class Program
    {

        static void Main(string[] args)
        {

            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Insert(7);
            binaryTree.Insert(4);
            binaryTree.Insert(9);
            binaryTree.Insert(1);
            binaryTree.Insert(6);
            binaryTree.Insert(8);
            binaryTree.Insert(10);


            Console.WriteLine("Print Pre-Order Traversal");
            binaryTree.PreOrderTraversal();

            Console.WriteLine("Print In-Order Traversal in Ascending order");
            binaryTree.InOrderTraversalAsc();

            Console.WriteLine("Print In-Order Traversal in Descending order");
            binaryTree.InOrderTraversalDesc();

            Console.WriteLine("Print Post-Order Traversal");
            binaryTree.PostOrderTraversal();

            Console.Read();

        }

            //static void Main(string[] args)
            //{
            //    Console.WriteLine("Hello World!");

            //    //int[] nums = new int[] { 1, 1, 1, 1, 1, };

            //    //var result = RunningSum(nums);
            //    //foreach (var i in result)
            //    //{
            //    //    Console.WriteLine(i.ToString());
            //    //}



            //    Console.Read();
            //}
        
        //public static int[] RunningSum(int[] nums)
        //{
        //    int[] result = new int[nums.Length];

        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        int temp = 0;
        //        for (int j = 0; j < nums[i]; j++)
        //        {
        //           temp += nums[j];
        //        }
        //        result[i] = temp;
        //    }

        //    return result;
        //}

    }
}
