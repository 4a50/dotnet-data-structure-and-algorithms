using FizzBuzzTree;
using System;
using System.Collections.Generic;

namespace TestBench
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] arr = new int[] { 8, 4, 23, 42, 16, 15 };
      foreach(int n in arr) { Console.Write($"{n} => "); }
      Console.WriteLine();
      
      int[] sortedArr = QuickSort.QuickSort.QSort(arr, 0, arr.Length - 1);
      foreach (int n in sortedArr) { Console.Write($"{n} => "); }
    }
  }
}
