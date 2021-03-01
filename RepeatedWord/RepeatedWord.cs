using System;
using System.Text.RegularExpressions;

namespace DataStructures
{
  public class RepeatedWord
  {
    public HashTable Map { get; set; }
    public RepeatedWord()
    {
      Map = new HashTable();
    }
    //TODO: Understand that 'was' and 'time' hash out same.  Perhaps institute a KVP LL

    public string FindRepeatedWord(string phrase, bool normalize = true)
    {

      int hashWord = 0;
      string returnWord = "";
      string phraseWord = "";
      string[] parsedPhrase = Regex.Split(phrase, @"\W+");
      for (int i = 0; i < parsedPhrase.Length; i++)
      {
        if (normalize) { phraseWord = parsedPhrase[i].ToUpper(); }
        else { phraseWord = parsedPhrase[i]; }
        hashWord = Map.Hash(phraseWord);
        if (Map.Contains(phraseWord))
        {
          returnWord = phraseWord;
          return returnWord;
        }
        else
        {
          Map.Add(phraseWord, "value");
        }
      }
      Console.WriteLine();
      return returnWord;
      //TODO: Figure out how to determine the duplicate entry.  Regex OK

    }


  }
}
