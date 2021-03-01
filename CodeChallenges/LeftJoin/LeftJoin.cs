using DataStructures;
using System.Collections.Generic;

namespace LeftJoin
{
  public static class LeftJoin
  {
    public static List<string[]> LeftJoinHashTable(HashTable hOne, HashTable hTwo)
    {
      List<string[]> joiner = new List<string[]>();
      string[] insertString = new string[3];
      string hTwoValue;

      for (int i = 0; i < hOne.Map.Length; i++)
      {
        if (hOne.Map[i] != null)
        {          
          insertString[0] = hOne.Map[i].Head.Value.Key;
          insertString[1] = hOne.Map[i].Head.Value.Value;
          hTwoValue = hTwo.Get(insertString[0]);
          if (hTwoValue != null)
          {
            insertString[2] = hTwoValue;
          }
          else
          {
             insertString[2] = "NULL";
          }
          joiner.Add(insertString);
          insertString = new string[3];
        }
      }
      return joiner;
    }
  }
}
