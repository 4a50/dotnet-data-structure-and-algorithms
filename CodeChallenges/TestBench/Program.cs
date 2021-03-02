using DataStructures;
using System;
using System.Collections.Generic;
using Trees;

namespace TestBench
{
  class Program
  {
    static void Main(string[] args)
    {
      HashTable hOne = new HashTable(20);
      hOne.Add("fond", "enamored");
      hOne.Add("wrath", "anger");
      hOne.Add("diligent", "employed");
      hOne.Add("outfit", "garb");
      hOne.Add("guide", "usher");

      HashTable hTwo = new HashTable(20);
      hTwo.Add("fond", "adverse");
      hTwo.Add("wrath", "delight");
      hTwo.Add("diligent", "idle");
      hTwo.Add("guide", "follow");
      hTwo.Add("flow", "jam");

      hOne.Print();
      Console.WriteLine("\n\n");
      hTwo.Print();
      Console.ReadKey();
    }

  }
}
