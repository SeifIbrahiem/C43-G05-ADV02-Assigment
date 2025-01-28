namespace C43_G05_ADV02_Assigment
{

    #region example7
    public class MultiTypeQueue
    {
        private Queue<object> _queue = new Queue<object>();

        public void Enqueue(object item)
        {
            _queue.Enqueue(item);
        }

        public object Dequeue()
        {
            if (_queue.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }
            return _queue.Dequeue();
        }

        public int Count => _queue.Count;
        #endregion


        internal class Program
        {

            #region ex5
            //    public static int RemoveDuplicates(int[] nums)
            //    {
            //        if (nums.Length == 0)
            //        {
            //            return 0;
            //        }
            //        int slow = 0;
            //        for (int fast = 1; fast < nums.Length; fast++)
            //        {
            //            if (nums[slow] != nums[fast])
            //            {
            //                slow++;
            //                nums[slow] = nums[fast];
            //            }
            //        }
            //        return slow + 1;
            //    }
            //    public static void Main(string[] args)
            //    {
            //        int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            //        int k = RemoveDuplicates(nums);
            //        Console.WriteLine("Number of unique elements: " + k);
            //        Console.WriteLine("Array after removing duplicates:");
            //        for (int i = 0; i < k; i++)
            //        {
            //            Console.Write(nums[i] + " ");
            //        }
            //        Console.WriteLine();
            //    }
            //} 
            #endregion

            #region ex6
            //public static void RemoveOddNumbers(List<int> list)
            //{
            //    list.RemoveAll(x => x % 2 != 0);
            //}

            //public static void Main(string[] args)
            //{
            //    List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //    Console.WriteLine("Original List:");

            //    Console.WriteLine(string.Join(", ", numbers));

            //    RemoveOddNumbers(numbers);

            //    Console.WriteLine("List after removing odd numbers:");
            //    Console.WriteLine(string.Join(", ", numbers));
            //} 
            #endregion

            #region example7
            //public static void Main(string[] args)
            //{
            //    MultiTypeQueue queue = new MultiTypeQueue();

            //    queue.Enqueue(1);
            //    queue.Enqueue("Apple");
            //    queue.Enqueue(5.28);
            //    Console.WriteLine($"Queue Count: {queue.Count}");


            //} 
            #endregion


        }
    }
}
        

