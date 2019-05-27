using System;
using Bubblesort;
using InsertionSort;

namespace net
{
    class Program
    {
        static void Main(string[] args)
        {  
            Bubblesort.Bubblesort.BubbleSort();
            InsertionSort.InsertionSort.insertionSort();
        }
    }
}
