using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratices.Algorithm
{
    internal class FindMinMax
    {
        public static void PrintResult(int[] arr,int min , int max) 
        {
            Console.Write("Array:");
            foreach (int x in arr)
            {
                Console.Write("{0},",x);
            }
            Console.WriteLine("\nMin:{0} Max:{1}",min,max);

        }
        public static void PrintResult(List<int> list, int min, int max)
        {
            Console.Write("List:");
            foreach (int x in list)
            {
                Console.Write("{0},", x);
            }
            Console.WriteLine("\nMin:{0} Max:{1}", min, max);

        }
        public static int Start(List<int> arr, int left, int length, bool max)
        {
            if (length == 0)
            {
                return -1;
            }
            int target;
            if (max)
            {
                target = int.MinValue;
            }
            else
            {
                target = int.MaxValue;
            }


            if (length - 1 == 0)
            {
                return arr[left];
            }
            if (left >= length - 2)
            {
                if (arr[left] > arr[left + 1])
                {
                    if (max)
                    {
                        return arr[left];
                    }
                    return arr[left + 1];
                }
                else
                {
                    if (max)
                    {
                        return arr[left + 1];
                    }
                    return arr[left];
                }
            }

            target = Start(arr, left + 1, length, max);

            if (arr[left] > target)
            {
                if (max)
                {
                    return arr[left];
                }
                else
                {
                    return target;
                }
            }
            if (max)
            {
                return target;
            }
            return arr[left];
        }
        public static int Start(int[] arr , int left , int length, bool max) 
        {
            if (length == 0)
            {
                return -1;
            }
            int target;
            if (max) 
            {
                target = int.MinValue;
            }
            else 
            {
                target = int.MaxValue;
            }

           
            if(length - 1== 0) 
            {
                return arr[left];
            }
            if(left >= length - 2) 
            {
                if (arr[left] > arr[left + 1])
                {
                    if(max) 
                    {
                        return arr[left];
                    }
                    return arr[left + 1];
                }
                else 
                {
                    if (max) 
                    {
                        return arr[left+1];
                    }
                    return arr[left];
                }
            }

            target = Start(arr , left+1 , length, max);

            if (arr[left] > target) 
            {
                if (max) 
                {
                    return arr[left];
                }
                else 
                {
                    return target;
                }
            }
            if (max) 
            {
                return target;
            }
            return arr[left];
        }
    }
}
