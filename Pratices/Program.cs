using Pratices;
using Pratices.Algorithm;
using System;
using System.Collections;
using System.Collections.Generic;

class Program 
{
    static void Main(string[] args) 
    {
        MinMax();
    }
    public static void MinMax() 
    {
        int[] arr = CollectionGenerator.ArrayGenerateWithRandom(10, 0, 100);
        int max = FindMinMax.Start(arr, 0, arr.Length, true);
        int min = FindMinMax.Start(arr, 0, arr.Length, false);
        FindMinMax.PrintResult(arr, min, max);
        List<int> list = CollectionGenerator.ListGenerateWithRandom(10, 0, 100);
        max = FindMinMax.Start(list, 0, list.Count, true);
        min = FindMinMax.Start(list, 0, list.Count, false);
        FindMinMax.PrintResult(list, min, max);

    }

}