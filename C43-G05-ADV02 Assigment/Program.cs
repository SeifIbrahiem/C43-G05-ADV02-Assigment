namespace C43_G05_ADV02_Assigment
{
    internal class Program
    {

        #region ex5
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            int slow = 0;
            for (int fast = 1; fast < nums.Length; fast++)
            {
                if (nums[slow] != nums[fast])
                {
                    slow++;
                    nums[slow] = nums[fast];
                }
            }
            return slow + 1;
        }
        public static void Main(string[] args)
        {
            int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int k = RemoveDuplicates(nums);
            Console.WriteLine("Number of unique elements: " + k);
            Console.WriteLine("Array after removing duplicates:");
            for (int i = 0; i < k; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();
        }
    } 
    #endregion

}

        

