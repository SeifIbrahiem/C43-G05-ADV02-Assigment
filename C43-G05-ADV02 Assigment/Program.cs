namespace C43_G05_ADV02_Assigment
{
    internal class Program
    {
        public static void printqueue(Queue<int> queue)
        {
            Console.WriteLine("Original Queue:");
            foreach (int item in queue)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Reversed Queue:");
            foreach (int item in queue)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            #region ex3
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);
            printqueue(queue);
            queue.Reverse();
            Console.WriteLine($"reverse:{queue}"); 
            #endregion


        }
    }
}
