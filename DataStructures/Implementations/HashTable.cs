using System;
using System.Collections.Generic;
using System.Text;
using DataStructures;

namespace DataStructures
{
  public class HashTable
  {
   
    public LinkedList<KeyValuePair<string, string>>[] Map { get; set; }
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
    public void Add(string key, string value)
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
    
    public string Get (string key)
    {
      int hashBucket = Hash(key);
      if (hashBucket< 0 || hashBucket > Map.Length - 1) { return  "Value is Not in Hash Table"; }

      LinkedList<KeyValuePair<string, string>> bucket = Map[hashBucket];

      Node<KeyValuePair<string, string>> currentNode = bucket.Head;
      while (currentNode != null)
      {
        if(currentNode.Value.Key == key) { return currentNode.Value.Value; }
        currentNode = currentNode.Next;
      }
      return null;
    }

    public bool Contains (string key)
    {
      int keyHash = Hash(key);
      if (keyHash < 0 || keyHash > Map.Length - 1 || Map[keyHash] == null) { return false; }
      LinkedList<KeyValuePair<string, string>> bucket = Map[keyHash];

      Node<KeyValuePair<string, string>> currentNode = bucket.Head;
      while (currentNode != null)
      {
        if (currentNode.Value.Key == key) { return true; }
      }
      return false;
    }

    

    //Print Method for a visual of what is going on
    public void Print()
    {
      for (int i = 0; i < Map.Length; i++)
      {
        if (Map[i] == null)
        {
          Console.WriteLine($"Bucket {i}: Null");
        }
        else
        {
          Console.Write($"Bucket {i}: ");

          Node<KeyValuePair<string, string>> current = Map[i].Head;
          while (current != null)
          {
            Console.Write($"[{current.Value.Key} : {current.Value.Value}] => ");
            current = current.Next;
          }
          Console.WriteLine();
        }
      }
    }
  }
}
