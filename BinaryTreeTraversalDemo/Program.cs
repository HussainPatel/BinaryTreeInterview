using System;

namespace BinaryTreeTraversalDemo
{
    class Program
    {

        static void Main(string[] args)
        {

            BinaryTree tree = new BinaryTree();

            tree.Insert(7);
            tree.Insert(4);
            tree.Insert(9);
            tree.Insert(1);
            tree.Insert(6);
            tree.Insert(8);
            tree.Insert(10);


            Console.WriteLine("Print Pre-Order Traversal");
            tree.PreOrderTraversal();

            Console.WriteLine("Print In-Order Traversal in Ascending order");
            tree.InOrderTraversalAsc();

            Console.WriteLine("Print In-Order Traversal in Descending order");
            tree.InOrderTraversalDesc();

            Console.WriteLine("Print Post-Order Traversal");
            tree.PostOrderTraversal();

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
