using System;

namespace InsertionSort
{
    class InsertionSort
    {
        public static void insertionSort()
        {
            int[] nums = {  5, 10, 3, 2, 4 , 1 };
            
            // variable for insertion value
            int newValue;

            for (int i = 0; i < nums.Length; i++)
            {
                newValue = nums[i];

                int j = i;

                while (j > 0 && nums[j - 1] > newValue)
                {
                    nums[j] =  nums[j - 1];
                    
                    j--;
                }
                nums[j] = newValue;
            }
            foreach (int val in nums)
            {
                Console.Write(val + ",");
            }
            Console.WriteLine();
        }
    }
}