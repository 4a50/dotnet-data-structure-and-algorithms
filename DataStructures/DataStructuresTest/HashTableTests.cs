using DataStructures;
using System.Collections.Generic;
using Trees;
using Xunit;
namespace DataStructuresTest
{
  public class HashTableTesting
  {
    HashTable hash = new HashTable(10);
    [Fact]
    public void Successfully_Add_A_Value_To_HashTable()
    {      
      hash.Add("Fox McCloud", "Leader");
      hash.Add("Falco Lombardi", "Hot-Shot");
      hash.Add("Slippy Toad", "No-One Cares");
      hash.Add("Peppy Hare", "Father Figure");
      hash.Add("General Pepper", "Leader");      
      hash.Add("Andross", "Antagonist");
      Assert.Equal("No-One Cares", hash.Map[5].Head.Value.Value);
      Assert.Equal("Slippy Toad", hash.Map[5].Head.Value.Key);
    }


  }
}
