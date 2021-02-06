using DataStructures;
using FIFOAnimalShelter;
using FizzBuzzTree;
using System.Collections.Generic;
using Xunit;

namespace CodeChallengeTests
{
  public class CodeChallengeUnitTest
  {
    /// <summary>
    /// If the returned Node is the proper Head, indicating a properly zipped Linked List
    /// </summary>
    [Fact]
    public void Zipped_Linked_List_Returns_Expected_Head_Node()
    {
      LinkedList aList = new LinkedList();
      aList.Insert(10);
      aList.Insert(8);
      aList.Insert(6);
      aList.Insert(4);
      aList.Insert(2);
      LinkedList bList = new LinkedList();
      bList.Insert(9);
      bList.Insert(7);
      bList.Insert(5);
      bList.Insert(3);
      bList.Insert(1);
      Assert.Equal(9, DataStructures.Program.ZipLists(aList, bList).Value);
    }
    [Fact]
    public void Zipped_Linked_List_Does_Not_Return_A_Previous_Node()
    {
      LinkedList aList = new LinkedList();
      aList.Insert(10);
      aList.Insert(8);
      aList.Insert(6);
      aList.Insert(4);
      aList.Insert(2);
      LinkedList bList = new LinkedList();
      bList.Insert(9);
      bList.Insert(7);
      bList.Insert(5);
      bList.Insert(3);
      bList.Insert(1);
      Assert.NotEqual(10, DataStructures.Program.ZipLists(aList, bList).Value);
    }
    [Fact]
    public void Psuedo_Queue_Test_Enqueue_Int()
    {
      QueueWithStacks testQueue = new QueueWithStacks();
      testQueue.stack1.Push(5);
      testQueue.stack1.Push(10);
      testQueue.stack1.Push(15);
      testQueue.stack1.Push(20);
      testQueue.stack1.Push(25);
      testQueue.Enqueue(30);
      Assert.Equal(30, testQueue.stack1.Top.Value);
    }
    [Fact]
    public void Psuedo_Queue_Test_Dequeue_Int()
    {
      QueueWithStacks testQueue = new QueueWithStacks();
      testQueue.stack1.Push(5);
      testQueue.stack1.Push(10);
      testQueue.stack1.Push(15);
      testQueue.stack1.Push(20);
      testQueue.stack1.Push(25);

      Assert.Equal(10, testQueue.Dequeue());
    }
    [Fact]
    public void Psuedo_Queue_Dequeue_Empty()
    {
      QueueWithStacks testQueue = new QueueWithStacks();
      Assert.Equal(-1, testQueue.Dequeue());
    }
    /// <summary>
    /// Tests The Enqueue Method to ensure proper operation
    /// </summary>
    [Fact]
    public void Animal_Shelter_Enqueue()
    {
      AnimalShelter testShelter = new AnimalShelter();
      testShelter.Enqueue(new Animal("Dog"));
      testShelter.Enqueue(new Animal("Cat"));
      testShelter.Enqueue(new Animal("Cat"));
      testShelter.Enqueue(new Animal("Dog"));
      testShelter.Enqueue(new Animal("Cat"));

      Assert.Equal("Cat", testShelter.animalQueue.Rear.Value.Species);
    }
    /// <summary>
    /// Tests is the right animal is Dequeued for adoption
    /// </summary>
    [Fact]
    public void Animal_Shelter_Dequeue_To_Pref()
    {
      AnimalShelter testShelter = new AnimalShelter();
      testShelter.Enqueue(new Animal("Cat"));
      testShelter.Enqueue(new Animal("Dog"));
      testShelter.Enqueue(new Animal("Cat"));
      testShelter.Enqueue(new Animal("Cat"));
      testShelter.Enqueue(new Animal("Dog"));
      testShelter.Dequeue("Cat");
      Assert.Equal("Dog", testShelter.Dequeue("Dog").Species);
    }


    /// <summary>
    /// Test the animal shelter to return a NULL if pref is not a dog or cat.
    /// </summary>
    [Fact]
    public void Animal_Shelter_Return_Null_With_Invalid_Input()
    {
      AnimalShelter testShelter = new AnimalShelter();
      testShelter.Enqueue(new Animal("Cat"));
      testShelter.Enqueue(new Animal("Dog"));
      testShelter.Enqueue(new Animal("Cat"));
      testShelter.Enqueue(new Animal("Cat"));
      testShelter.Enqueue(new Animal("Dog"));
      Assert.Null(testShelter.Dequeue("Platypus"));
    }
    /// <summary>
    /// Tests a Balanced String.  Expects a true return
    /// </summary>
    [Fact]
    public void Test_Multi_Bracket_Validation_Balanced()
    {
      string testString = "()[[Extra Characters]]";
      Assert.True(MultBracketValidation.MultiBracketValidation(testString));
    }
    /// <summary>
    /// Tests an unbalanced string.  Expects a false.
    /// </summary>
    [Fact]
    public void Test_Multi_Bracket_Validation_Unbalanced()
    {
      string testString = "{(})";
      Assert.False(MultBracketValidation.MultiBracketValidation(testString));
    }
    [Fact]
    public void Test_FizzBuzz_Tree()
    {
      KAryTree<int> ktree = new KAryTree<int>(15);
      List<int> seedNodes = new List<int> { 30, 90, 5 };
      int count = 0;
      foreach (int i in seedNodes) { ktree.Root.Leaves.Add(new KAryNode<int>(i)); }
      foreach (KAryNode<int> ki in ktree.Root.Leaves)
      {
        if (count++ == 0) { ki.Leaves.Add(new KAryNode<int>(10)); }

        if (count++ == 1)
        {
          ki.Leaves.Add(new KAryNode<int>(90));
          ki.Leaves.Find(p => p.Value == 90).Leaves.Add(new KAryNode<int>(33));
        }

        if (count++ == 2)
        {
          ki.Leaves.Add(new KAryNode<int>(5));
          ki.Leaves.Find(p => p.Value == 5).Leaves.Add(new KAryNode<int>(7));
          ki.Leaves.Find(p => p.Value == 5).Leaves.Add(new KAryNode<int>(60));
        }
        ktree.FizzBuzzIterate(ktree.Root, new KAryNode<string>());
        //Test
        List<KAryNode<string>> expectedString = new List<KAryNode<string>>();
        expectedString.Add(new KAryNode<string>("FizzBuzz"));
        expectedString.Add(new KAryNode<string>("FizzBuzz"));
        expectedString.Add(new KAryNode<string>("Buzz"));

        Assert.Equal(expectedString, ktree.FizzTree.Root.Leaves);
      }
    }
  }
}
