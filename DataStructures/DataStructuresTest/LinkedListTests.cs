using DataStructures;
using System;
using Xunit;
namespace DataStructuresTest
{
  public class LinkListTests
  {
    [Fact]
    public void Linked_List_Created_With_A_Value_Has_Correct_Head()
    {
      int value = 2;

      LinkedList<int> testList = new LinkedList<int>(value);

      Assert.Equal(testList.Head.Value, value);

    }

    [Fact]
    public void After_Insert_New_Node_Is_Head()
    {
      LinkedList<int> testList = new LinkedList<int>(1);
      // H(2) -> (1)
      testList.Insert(2);

      Assert.Equal(2, testList.Head.Value);
    }

    [Fact]
    public void After_Insert_New_Head_Next_is_Old_Head()
    {
      // H(1)
      LinkedList<int> testList = new LinkedList<int>(1);
      Node<int> oldHead = testList.Head;

      // H(2) -> (1)
      testList.Insert(2);

      Assert.Equal(oldHead, testList.Head.Next);
    }
    //Start My Own
    [Fact]
    public void Find_Value_In_The_Linked_List()
    {
      LinkedList<int> testList = new LinkedList<int>(4);
      testList.Insert(23);
      Assert.True(testList.Includes(23));

    }
    [Fact]
    public void Does_Not_Find_Value_In_Linked_List()
    {
      LinkedList<int> testList = new LinkedList<int>(4);
      testList.Insert(23);
      testList.Insert(500);
      Assert.False(testList.Includes(66));
    }
    [Fact]
    public void Properly_Insert_Multiple_Nodes()
    {
      LinkedList<int> testList = new LinkedList<int>(4);
      testList.Insert(2);
      testList.Insert(22);
      testList.Insert(81);
      testList.Insert(20);
      Assert.Equal(20, testList.Head.Value);
    }
    [Fact]
    public void Properly_Returns_All_Values_In_List()
    {
      LinkedList<int> testList = new LinkedList<int>(34);
      string testStr = "<490> => <162> => <34> => Null";
      testList.Insert(162);
      testList.Insert(490);
      Assert.Equal(testStr, testList.Print());
    }
    [Fact]
    public void Create_An_Empty_List()
    {
      LinkedList<int> testList = new LinkedList<int>();
      Assert.Null(testList.Head);
    }
    [Fact]
    public void Append_A_Value_To_Linked_List()
    {
      LinkedList<int> testList = new LinkedList<int>(12);
      testList.Insert(2);
      testList.Insert(22);
      testList.Insert(81);
      testList.Insert(20);

      Assert.Equal(756, testList.Append(756));
    }
    [Fact]
    public void Insert_New_Value_After_Requested_Value()
    {
      LinkedList<int> testList = new LinkedList<int>();
      testList.Insert(2);
      testList.Insert(22);
      testList.Insert(81);
      testList.Insert(1999);
      testList.Insert(741);
      Assert.Equal(2, testList.InsertAfter(22, 705));

    }
    [Fact]
    public void Insert_New_Value_After_Value_Not_Found()
    {
      LinkedList<int> testList = new LinkedList<int>();
      testList.Insert(2);
      testList.Insert(22);
      testList.Insert(81);
      testList.Insert(1999);
      testList.Insert(741);
      Assert.Equal(0, testList.InsertAfter(123, 705));
    }
    [Fact]
    public void Insert_New_Value_Before_Requested_Value()
    {
      LinkedList<int> testList = new LinkedList<int>();
      testList.Insert(2);
      testList.Insert(22);
      testList.Insert(81);
      testList.Insert(1999);
      testList.Insert(741);
      Assert.Equal(22, testList.InsertBefore(22, 199));
    }
    [Fact]
    public void Insert_New_Value_Before_Requested_Value_Not_Found()
    {
      LinkedList<int> testList = new LinkedList<int>();
      testList.Insert(2);
      testList.Insert(22);
      testList.Insert(81);
      testList.Insert(1999);
      testList.Insert(741);
      Assert.Equal(0, testList.InsertBefore(100, 199));
    }
    /// <summary>
    /// These tests the Kth value from the Tail in a linked List
    /// </summary>
    [Fact]
    public void Kth_Node_Location_Of_Node_Is_Beyond_The_Range_Of_The_List()
    {
      LinkedList<int> testList = new LinkedList<int>();
      testList.Insert(12);
      testList.Insert(24);
      testList.Insert(48);
      testList.Insert(60);
      testList.Insert(72);
      var except = Assert.Throws<Exception>(() => testList.LocateKthNodeFromTail(6));

      Assert.Equal("K is outside the length of the list", except.Message);
    }
    [Fact]
    public void Kth_Value_And_Linked_List_Length_Are_Equal()
    {
      LinkedList<int> testList = new LinkedList<int>();
      testList.Insert(12);
      testList.Insert(24);
      testList.Insert(48);
      testList.Insert(60);
      testList.Insert(72);
      Assert.Equal(72, testList.LocateKthNodeFromTail(5));
    }
    [Fact]
    public void K_Value_Is_A_Negative_Number()
    {
      LinkedList<int> testList = new LinkedList<int>();
      testList.Insert(12);
      testList.Insert(24);
      testList.Insert(48);
      testList.Insert(60);
      testList.Insert(72);
      var except = Assert.Throws<Exception>(() => testList.LocateKthNodeFromTail(-1));

      Assert.Equal("K is less than 0", except.Message);
    }
    [Fact]
    public void Kth_Node_In_A_Linked_List_Of_One()
    {
      LinkedList<int> testList = new LinkedList<int>();
      testList.Insert(12);
      Assert.Equal(12, testList.LocateKthNodeFromTail(0));
    }
    [Fact]
    public void Find_Kth_Value_In_A_Linked_List()
    {
      LinkedList<int> testList = new LinkedList<int>();
      testList.Insert(12);
      testList.Insert(24);
      testList.Insert(48);
      testList.Insert(60);
      testList.Insert(72);
      Assert.Equal(60, testList.LocateKthNodeFromTail(3));
    }

  }
}
