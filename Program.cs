using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section4._27
{
    internal class Program
    {
        public static void runApp()
        {
            Console.WriteLine("Enter No of Elements");
            int n = int.Parse(Console.ReadLine());
            string[] Arr = new string[n];
            Console.WriteLine("Enter array elements");
            for (int i = 0; i < n; i++)
            {
                Arr[i] = Console.ReadLine();

            }
            Array.Sort(Arr);
            Console.WriteLine("Array Elements are");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Arr[i]);
            }
            int currElem = 0;
            Console.WriteLine("After Recursion");
            printViaRecursion(Arr,currElem);
           

        }
        public static void printViaRecursion(string[] arr, int currElem)
        {

            Console.WriteLine(arr[currElem]);
            if (currElem < arr.Length - 1)
            {
                printViaRecursion(arr, currElem + 1);
                Console.ReadKey();
            }
        }

        static void Main(string[] args)
        {
            runApp();
        }
    }
}
