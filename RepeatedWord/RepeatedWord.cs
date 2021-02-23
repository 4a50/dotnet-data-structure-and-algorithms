using System;
using System.Text.RegularExpressions;

namespace DataStructures
{
  public class RepeatedWord
  {
      public LinkedList<string>[] Map { get;set; }
    public RepeatedWord(int size)
    {
      Map = new LinkedList<string>[size];
    }
//TODO: Understand that 'was' and 'time' hash out same.  Perhaps institute a KVP LL
    public int Hash(string word)
    {
      int hashValue = 0;
      char[] stringChar = word.ToCharArray();
      for (int i = 0; i < stringChar.Length; i++)
      {
        hashValue += stringChar[i];
      }
      hashValue = (hashValue * 997) % Map.Length;
      return hashValue;
    }
    public string FindRepeatedWord(string phrase)
    {      
      int hash = 0;
      string word = "";
      string[] parsedPhrase = Regex.Split(phrase, @"\W");
      //TODO: Figure out how to determine the duplicate entry.  Regex OK
      for (int i = 0; i < parsedPhrase.Length; i++)
      {
        word = parsedPhrase[i];
        if (word != "")
        {
          hash = Hash(parsedPhrase[i]);
          if (Map[hash] == null)
          {
            
            Map[hash] = new LinkedList<string>();
            Map[hash].Insert(word);
          }
          else
          {
            if (Map[hash].Includes(parsedPhrase[i]))
            {              
              return word;
            }
          }
        Console.WriteLine($"I -> {i} Word -> <{word}> Hash -> {hash}");
        }
      }

      return word;
    }


  }
}
