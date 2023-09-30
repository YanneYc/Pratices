using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratices.Algorithm
{
    internal class SwapElement
    {
        public static void Swap(int[] arr , int left , int right) 
        {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
        }
        public static void Swap(List<int> arr, int left, int right)
        {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
        }
    }
}
