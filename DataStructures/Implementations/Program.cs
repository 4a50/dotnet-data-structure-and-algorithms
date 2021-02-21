using System;
namespace DataStructures

{
  class Program
  {   

    static void Main(string[] args)
    {
      HashTable hash = new HashTable(10);
      hash.Print();
      hash.Add("Fox McCloud", "Leader");
      hash.Add("Falco Lombardi", "Hot-Shot");
      hash.Add("Slippy Toad", "No-One Cares");
      hash.Add("Peppy Hare", "Father Figure");
      hash.Add("General Pepper", "Leader");
      hash.Add("Andross", "Antagonist");
      hash.Print();
      Console.ReadKey();


    }
  }
}
