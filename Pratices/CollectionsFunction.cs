using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratices
{
    internal class CollectionsFunction
    {
        public static void PrintCollections(int[] arr) 
        {
            foreach(int i in arr) 
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }
        public static void PrintCollections(List<int> arr) 
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
