using System;
using System.Collections.Generic;
using System.Text;
using DataStructures;

namespace DataStructures
{
  class HashTable
  {
   
    private DataStructures.LinkedList<KeyValuePair<string, string>>[] Map { get; set; }
    public HashTable(int size)
    {
      Map = new LinkedList <KeyValuePair<string, string>>[size];
    }

    //Create a way to Hash the input. (multiply by a large prime
    private int Hash (string key)
    {      
      int hashValue = 0;
      //convert the string to a char[] (theses are ASCII Values <--ints
      char[] charString = key.ToCharArray();
      for (int i = 0; i < charString.Length; i++)
      {
        hashValue += charString[i];
      }
      //This is where we create the unique-ish hash value by mulitplying by some sort of random prime
      hashValue = (hashValue * 997) % Map.Length;
      Console.WriteLine($"HashValue * 997 % MapLength: {hashValue}");
      
      return hashValue;
    }
    
    //How to store the data in a has table. (assign it a bucket, and put it there.
    public void Set(string key, string value)
    {
      //Hash the Key
      int hashKey = Hash(key);
      //Determine if there is a LinkedList of Values started for that bucket, if not start one
      if (Map[hashKey] == null)
      {
        Map[hashKey] = new LinkedList<KeyValuePair<string, string>>(); 
      }
      // Create a new KeyValue Pair ready for entry into the Linked List at the appropriate bucket
      KeyValuePair<string, string> valueEntry = new KeyValuePair<string, string>(key, value);

      //Inserts the KVP (node) into the LinkedList in the appropriate bucket.

      Map[hashKey].Insert(valueEntry);

    }
    //Make an array for buckets to store the data == predertermined size

    //
  }
}
