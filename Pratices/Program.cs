using Pratices;
using Pratices.Algorithm;
using System;
using System.Collections;
using System.Collections.Generic;

class Program 
{
    static void Main(string[] args) 
    {
        //MinMax();
        Qsort();
    }
    public static void MinMax() 
    {
        int[] arr = CollectionGenerator.ArrayGenerateWithRandom(10, 0, 100);
        int max = FindMinMax.Start(arr, 0, arr.Length, true);
        int min = FindMinMax.Start(arr, 0, arr.Length, false);
        FindMinMax.PrintResult(arr, min, max);
    }
    static void Qsort() 
    {
        int[] arr = CollectionGenerator.ArrayGenerateWithRandom(20,0,100);
        SortedOrderCheck.Check(arr); 
        QuickSort.Sort(arr,0,arr.Length-1,false);
        SortedOrderCheck.Check(arr);

    }

}