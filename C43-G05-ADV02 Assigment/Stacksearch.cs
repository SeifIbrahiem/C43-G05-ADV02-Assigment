using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_ADV02_Assigment
{
    internal class Stacksearch
    {
        public static void PushAndSearch(int[] numbers, int target)
        {
            Stack<int> stack = new Stack<int>();
            int count = 0;

            foreach (int num in numbers)
            {
                stack.Push(num);
                count++;

                if (num == target)
                {
                    Console.WriteLine($"Target was found successfully and the count = {count}");
                    return;
                }
            }

            Console.WriteLine("Target was not found.");
        }
            public static void Main(string[] args)
            {
                int[] numbers = { 5, 2, 8, 1, 9, 3 };
                int target = 8;

                PushAndSearch(numbers, target);
            }
    }
}
