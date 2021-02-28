using System;
using System.Text.RegularExpressions;

namespace DataStructures
{
  public class RepeatedWord
  {
    public HashTable Map { get;set; }
    public RepeatedWord()
    {
      Map = new HashTable();
    }
//TODO: Understand that 'was' and 'time' hash out same.  Perhaps institute a KVP LL
    
    public string FindRepeatedWord(string phrase)
    {      
      int hashWord = 0;
      string word = "";
      string[] parsedPhrase = Regex.Split(phrase, @"\W+");
      for (int i = 0; i < parsedPhrase.Length; i++)
      {        
        hashWord = Map.Hash(parsedPhrase[i]);
        if (Map.Contains(parsedPhrase[i]))
        {
          word = parsedPhrase[i];
          return word;
        }
        else
        {
          Map.Add(parsedPhrase[i], "value");
        }
      }
      Console.WriteLine();
      return word;
      //TODO: Figure out how to determine the duplicate entry.  Regex OK
      
    }


  }
}
