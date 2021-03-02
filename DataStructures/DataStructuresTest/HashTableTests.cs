using DataStructures;
using Xunit;
namespace DataStructuresTest
{
  public class HashTableTesting
  {

    [Fact]
    public void Successfully_Add_A_Value_To_HashTable()
    {
      HashTable hash = new HashTable(10);
      hash.Add("Fox McCloud", "Leader");
      hash.Add("Falco Lombardi", "Hot-Shot");
      hash.Add("Slippy Toad", "No-One Cares");
      hash.Add("Peppy Hare", "Father Figure");
      hash.Add("General Pepper", "Leader");
      hash.Add("Andross", "Antagonist");
      Assert.Equal("No-One Cares", hash.Map[5].Head.Value.Value);
      Assert.Equal("Slippy Toad", hash.Map[5].Head.Value.Key);
    }
    [Fact]
    public void Retrieve_A_Known_Value_From_A_Key()
    {
      HashTable hash = new HashTable(10);
      hash.Add("Fox McCloud", "Leader");
      hash.Add("Falco Lombardi", "Hot-Shot");
      hash.Add("Slippy Toad", "No-One Cares");
      hash.Add("Peppy Hare", "Father Figure");
      hash.Add("General Pepper", "Leader");
      hash.Add("Andross", "Antagonist");

      string key = "Peppy Hare";
      string value = "Father Figure";

      Assert.Equal(value, hash.Get(key));
    }
    [Fact]
    public void Unable_To_Retieve_A_Known_Value_From_A_Key_That_Does_Not_Exist()
    {
      HashTable hash = new HashTable(10);
      hash.Add("Fox McCloud", "Leader");
      hash.Add("Falco Lombardi", "Hot-Shot");
      hash.Add("Slippy Toad", "No-One Cares");
      hash.Add("Peppy Hare", "Father Figure");
      hash.Add("General Pepper", "Leader");
      hash.Add("Andross", "Antagonist");

      string key = "Princess Daisy";

      Assert.Null(hash.Get(key));
    }
    [Fact]
    public void Key_Is_Contained_In_Hash_Table()
    {
      HashTable hash = new HashTable(10);
      hash.Add("Fox McCloud", "Leader");
      hash.Add("Falco Lombardi", "Hot-Shot");
      hash.Add("Slippy Toad", "No-One Cares");
      hash.Add("Peppy Hare", "Father Figure");
      hash.Add("General Pepper", "Leader");
      hash.Add("Andross", "Antagonist");

      string key = "General Pepper";
      Assert.True(hash.Contains(key));
    }
    [Fact]
    public void Key_Is_NOT_Contained_In_Hash_Table()
    {
      HashTable hash = new HashTable(10);
      hash.Add("Fox McCloud", "Leader");
      hash.Add("Falco Lombardi", "Hot-Shot");
      hash.Add("Slippy Toad", "No-One Cares");
      hash.Add("Peppy Hare", "Father Figure");
      hash.Add("General Pepper", "Leader");
      hash.Add("Andross", "Antagonist");

      string key = "Alex Kidd";

      Assert.False(hash.Contains(key));
    }
  }
}
