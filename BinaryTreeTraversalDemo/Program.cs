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


            //var result = binaryTree.FindLinear(1);
            //Console.WriteLine("Value found in tee: {0}", result.ToString());

            // To Do
            //var result1 = binaryTree.FindRecursive(1);
            //Console.WriteLine("Value found in tee: {0}", result1);




            // Tree Traversal
            //Console.WriteLine("Print Pre-Order Traversal");
            //binaryTree.PreOrderTraversal();

            //Console.WriteLine("Print In-Order Traversal in Ascending order");
            //binaryTree.InOrderTraversalAsc();

            Console.WriteLine("Print In-Order Traversal  List in Asc order = Magic - ddeclare the IList of integers at class level");
            var result = binaryTree.InOrderTraversalListAsc();

            Console.Write("[");
            foreach (var i in result)
            {
                Console.Write(i + ",");
            }
            Console.Write("]");

            Console.WriteLine();

            Console.WriteLine("Print In-Order Traversal  List in Asc order   - Magic - create a sub method to return the IList of integers");
            var result1 = binaryTree.InOrderTraversalListAsc1();
            Console.Write("[");
            foreach (var i in result1)
            {
                Console.Write(i + ",");
            }
            Console.Write("]");




            //Console.WriteLine("Print In-Order Traversal in Descending order");
            //binaryTree.InOrderTraversalDesc();



            //Console.WriteLine("Print Post-Order Traversal");
            //binaryTree.PostOrderTraversal();


            // Height of Tree
            // var result = binaryTree.HeightofTree();
            // Console.WriteLine("Height of tree is {0}", result);


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
