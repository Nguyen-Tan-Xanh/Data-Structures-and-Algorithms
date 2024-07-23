using Data_Structures_and_Algorithms.Sorting;
using System;

namespace Data_Structures_and_Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 1, 4, 2, 8 };

            Console.WriteLine("Mang truoc khi sap xep:");
            Helper.PrintArray(arr);

            //Bubble_Sort.BubbleSort(arr);
            Selection_Sort.SelectionSort(arr);

            Console.WriteLine("Mang sau khi sap xep:");
            Helper.PrintArray(arr);
        }
    }
}
