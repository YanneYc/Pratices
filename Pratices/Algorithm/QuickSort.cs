using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratices.Algorithm
{
    internal class QuickSort
    {
        private static int Partition(int[]arr ,int left ,int right,bool accending) 
        {
            
            int i = left - 1;
            for(int j = left; j < right; j++)
            {
                if (accending) 
                {
                    if (arr[j] < arr[right]) 
                    {
                        i++;
                        SwapElement.Swap(arr, i, j);
                    }
                }
                else 
                {
                    if (arr[j] > arr[right])
                    {
                        i++;
                        SwapElement.Swap(arr, i, j);
                    }
                }
            }
            SwapElement.Swap(arr, i+1, right);
            return i + 1;
        }
        public static void Sort(int[] arr, int left, int right, bool accending)
        {
            if (left >= right)
            {
                return;
            }
            int p = Partition(arr, left, right, accending);
            Sort(arr, left, p - 1, accending);
            Sort(arr, p + 1, right, accending);
        }
        private static int Partition(List<int> arr, int left, int right, bool accending)
        {

            int i = left - 1;
            for (int j = left; j < right; j++)
            {
                if (accending)
                {
                    if (arr[j] < arr[right])
                    {
                        i++;
                        SwapElement.Swap(arr, i, j);
                    }
                }
                else
                {
                    if (arr[j] > arr[right])
                    {
                        i++;
                        SwapElement.Swap(arr, i, j);
                    }
                }
            }
            SwapElement.Swap(arr, i + 1, right);
            return i + 1;
        }
        public static void Sort(List<int> arr, int left, int right, bool accending)
        {
            if (left >= right)
            {
                return;
            }
            int p = Partition(arr, left, right, accending);
            Sort(arr, left, p - 1, accending);
            Sort(arr, p + 1, right, accending);
        }
    }
}
