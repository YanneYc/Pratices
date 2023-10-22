using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratices
{
    internal class SortedOrderCheck
    {
        public static void Check(int[] arr) 
        {
            if (IsAscending(arr))
            {
                CollectionsFunction.PrintCollections(arr);
                Console.WriteLine("Ascending sorted");
                return;
            }
            else if(IsDescending(arr))
            {
                CollectionsFunction.PrintCollections(arr);
                Console.WriteLine("Descending sorted");
                return;
            }
            CollectionsFunction.PrintCollections(arr);
            Console.WriteLine("Collection not sorted"); 
            
        }
        public static bool IsSorted(int[] arr) 
        {
            if (IsAscending(arr)) 
            {
                return true;
            }
            else if (IsDescending(arr)) 
            {
                return true;
            }
            else 
            {
                return false;
            }
               
        }
        public static bool IsAscending(int[] arr) 
        {
            int size = arr.Length -1;
            for(int i = 0; i < size; i++) 
            {
                if (arr[i] > arr[i + 1]) 
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsDescending(int[] arr) 
        {
            int size = arr.Length - 1;
            for (int i = 0; i < size; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    return false;
                }
            }
            return true;

        }
        public static bool IsAscending(List<int>arr)
        {
            int size = arr.Count - 1;
            for (int i = 0; i < size; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsDescending(List<int> arr)
        {
            int size = arr.Count - 1;
            for (int i = 0; i < size; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    return false;
                }
            }
            return true;

        }
        public static bool IsSorted(List<int> arr)
        {
            if (IsAscending(arr))
            {
                return true;
            }
            else if (IsDescending(arr))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
