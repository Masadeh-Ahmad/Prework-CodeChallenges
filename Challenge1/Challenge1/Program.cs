using System;

namespace Challenge1
{
    class Program
    {
        public static int arrayMax(int[] arr, int num)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    count++;
                }
            }
            return count * num;
        }
        public static void leap()
        {
            Console.Write("Enter the year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                Console.WriteLine(year + " " + "is a Leap Year.");
            }
            else
            {
                Console.WriteLine(year + " " + "is not a Leap Year.");
            }
        }
        public static string prefectSequence(int[] arr)
        {
            int sum = 0;
            int mul = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                mul *= arr[i];
            }
            if (sum == mul) return "Yes";
            return "No";
        }
        public static int[] sumRows(int[,] arr)
        {
            int[] result = new int[arr.GetLength(0)];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i, j];
                }
                result[i] = sum;
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************** ");
            Console.WriteLine("********************-  Array Max Result -******************** ");
            Console.WriteLine("***************************************************************** ");
            int[] arr = new int[5];
            Console.WriteLine("Please enter five integers!");

            for (int i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.WriteLine(" ");
            Console.Write("Please select a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The score is " +arrayMax(arr, num));
            Console.WriteLine("***************************************************************** ");
            Console.WriteLine("********************-  Leap Year Calculator -******************** ");
            Console.WriteLine("***************************************************************** ");
            leap();
            Console.WriteLine("***************************************************************** ");
            Console.WriteLine("********************-  Perfect Sequence -******************** ");
            Console.WriteLine("***************************************************************** ");
            int[] arr2 = { 1, 2, 3 };
            Console.Write("[");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i]+",");
            }
            Console.Write("]");
            Console.WriteLine(" Is A Prefect Sequence : " + prefectSequence(arr2));
            Console.WriteLine("***************************************************************** ");
            Console.WriteLine("********************-  Sum of Rows -******************** ");
            Console.WriteLine("***************************************************************** ");
            int[,] myArray = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };
            Console.WriteLine("[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } }");
            Console.Write("The Sum of The Rows : ");
            int [] Out = sumRows(myArray);
            for (int i = 0; i < Out.Length; i++)
            {
                Console.Write(Out[i]+" ");
            }

        }
    }
}
