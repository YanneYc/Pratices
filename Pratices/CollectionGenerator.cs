using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratices
{
    internal class CollectionGenerator
    {
        public static List<int> ListGenerateWithRandom(int count,int min , int max) 
        {
            Random rand = new Random();
            int holder = 0;
            List<int> result = new List<int>();
            for (int i = 0; i < count; i++) 
            {
                holder = rand.Next(min,max);
                result.Add(holder);
            }
            return result;
        }
        public static int[] ArrayGenerateWithRandom(int count , int min , int max)
        {
            Random rand = new Random();
            int holder = 0;
            int[] result = new int[count];
            for (int i = 0; i < count; i++)
            {
                holder = rand.Next(min, max);
                result[i] = holder;
            }
            return result;
        }
    }
}
