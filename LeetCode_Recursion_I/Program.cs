using System;

namespace LeetCode_Recursion_I
{
    class Program
    {
        static void Main(string[] args)
        {


            string str = "Hello World";
            //Console.WriteLine(str);

            //printReverseStringLinear(str);

            //Console.WriteLine();

            //Console.WriteLine(str);

            //printReverseStringRecursive(str);

            //char[] ch = new char[] { 'h', 'e', 'l', 'l', 'o' };

            //PrintReverseStringUsingLeftAndRightIndex(ch);

            int[] numbers = new int[] { 1, 2, 3, 4 };


            //SwapNodeInPairs(numbers);
            //foreach (var i in numbers)
            //{
            //    Console.Write(i);
            //}

            BinaryTree tree = new BinaryTree();


            tree.Insert(4);
            tree.Insert(2);
            tree.Insert(7);
            tree.Insert(1);
            tree.Insert(3);

            Console.WriteLine(tree.SearchNode(3));

            Console.Read();
        }

        #region"printReverseStringLinear"
        /// <summary>
        /// Linear Reverse string
        /// </summary>
        /// <param name="str"></param>
        public static void printReverseStringLinear(string str)
        {
            char[] ch = str.ToCharArray();

            for (int i = ch.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(ch[i]);
            }
        }

        #endregion

        #region "printReverseStringRecursive"
        /// <summary>
        /// Using Recursive call
        /// </summary>
        /// <param name="str"></param>
        public static void printReverseStringRecursive(string str)
        {
            char[] ch = str.ToCharArray();            
            Console.WriteLine(ch);
            printReverseHelper(0, ch);
        }
        private static void printReverseHelper(int index, char[] ch)
        {
            if (ch == null || ch.Length == 0 || index > ch.Length-1) return;
            printReverseHelper(index+1, ch);
            Console.Write(ch[index]);
        }

        #endregion

        #region"PrintReverseStringUsingLeftAndRightIndex"

        /// <summary>
        /// Print Reverse string using left and right index and recursively calling the helper method
        /// </summary>
        /// <param name="s"></param>
        public static void PrintReverseStringUsingLeftAndRightIndex(char[] s)
        {
            PrintReverseStringUsingLeftAndRightIndexHelper(s, 0, s.Length - 1);
            Console.WriteLine(s);
        }

        private static void PrintReverseStringUsingLeftAndRightIndexHelper(char[] s, int left, int right)
        {
            if (left > right) return;
            char tmp = s[left];
            s[left++] = s[right];
            s[right--] = tmp;

            PrintReverseStringUsingLeftAndRightIndexHelper(s, left, right);
        }

        #endregion

        #region"Swap Nodes in Pairs"

        public static void SwapNodeInPairs(int[] numbers)
        {
            SwapNodeInPairsHeloper(0, numbers);
        }

        private static void SwapNodeInPairsHeloper(int index, int[] numbers)
        {
            if (numbers == null || index > numbers.Length - 1) return;

                if (index % 2 == 0)
                {
                    var tmp = numbers[index];
                    numbers[index] = numbers[index + 1];
                    numbers[index + 1] = tmp;
                }
            SwapNodeInPairsHeloper(index + 1, numbers);
        }
        #endregion


        #region"Linked List"

        #endregion
    }


    public class BinaryTree
    {
        public TreeNode root;

        public void Insert(int value)
        {
            if (root == null)
            {
                root = new TreeNode(value);
                return;
            }

            var current = root;

            while (true)
            {
                if (value < current.value)
                {
                    if (current.leftChild == null)
                    {
                        current.leftChild = new TreeNode(value);
                        break;
                    }
                    current = current.leftChild;
                }
                else
                {
                    if (value > current.value)
                    {
                        if (current.rightChild == null)
                        {
                            current.rightChild = new TreeNode(value);
                            break;
                        }

                        current = current.rightChild;
                    }
                }
            }
        }

        public bool SearchNode(int value)
        {
            var current = root;
            if (current.value == value) return true;
            if (value < current.value)
            {
                current = current.leftChild;
                SearchNode(current.value);
            }
            else
            {
                current = current.rightChild;
                SearchNode(current.value);
            }

            return false;
        }

    }

    public class TreeNode
    {
        public int value;
        public TreeNode leftChild;
        public TreeNode rightChild;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.value = val;
            this.leftChild = left;
            this.rightChild = right;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

}