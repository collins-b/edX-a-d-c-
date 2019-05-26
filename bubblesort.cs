using System;
namespace Bubblesort
{
 class Bubblesort
 { 
  public static void BubbleSort() 
  {
    int[] nums = { 5, 10, 3, 2, 4 };

    bool swapped;

    do {
        swapped = false;
        for (int i = 0; i < nums.Length - 1; i++) {
            if (nums[i] > nums[i + 1]) {
                int temp = nums[i + 1];

                nums[i + 1] = nums[i];

                nums[i] = temp;

                swapped = true;
            }
        }
    } while(swapped == true);
    
    for(int i = 0; i < nums.Length; i++) {
        Console.Write("{0}, ");
    }
  }
 }
}