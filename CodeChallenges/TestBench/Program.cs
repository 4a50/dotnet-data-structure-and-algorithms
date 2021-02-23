using DataStructures;
using FizzBuzzTree;
using System;
using System.Collections.Generic;

namespace TestBench
{
  class Program
  {
    static void Main(string[] args)
    {
      string str = "Once upon a time, there was a brave princess who...";
      RepeatedWord repeate = new RepeatedWord(50);
      Console.WriteLine($"Repeated Word: {repeate.FindRepeatedWord(str)}");
      for (int i = 0; i < repeate.Map.Length; i++)
      {
        
        Console.Write($"[{i}] => ");
        if (repeate.Map[i] == null)
        {
          Console.Write("Null");
          Console.WriteLine();
        }
        else { repeate.Map[i].Print(); }
      }
    }
  }
}
