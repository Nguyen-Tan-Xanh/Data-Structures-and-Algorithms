using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_Algorithms.Sorting
{
    internal class Quick_Sort
    {
        // Hàm sắp xếp nhanh
        public static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                // Phân chia mảng và lấy chỉ số của pivot
                int pi = Partition(arr, low, high);

                // Sắp xếp phần bên trái của pivot
                QuickSort(arr, low, pi - 1);

                // Sắp xếp phần bên phải của pivot
                QuickSort(arr, pi + 1, high);
            }
        }

        // Hàm phân chia mảng
        private static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = (low - 1);

            for (int j = low; j < high; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    // Hoán đổi arr[i] và arr[j]
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // Hoán đổi arr[i + 1] và arr[high] (pivot)
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }
    }
}
