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
      DataStructures.LinkedList<int> aList = new DataStructures.LinkedList<int>();
      aList.Insert(10);
      aList.Insert(8);
      aList.Insert(6);
      aList.Insert(4);
      aList.Insert(2);
      DataStructures.LinkedList<int> bList = new DataStructures.LinkedList<int>();
      bList.Insert(9);
      bList.Insert(7);
      bList.Insert(5);
      bList.Insert(3);
      bList.Insert(1);
      Assert.Equal(9, DataStructures.LinkedList<int>.ZipLists(aList, bList).Value);
    }
    [Fact]
    public void Zipped_Linked_List_Does_Not_Return_A_Previous_Node()
    {
      DataStructures.LinkedList<int> aList = new DataStructures.LinkedList<int>();
      aList.Insert(10);
      aList.Insert(8);
      aList.Insert(6);
      aList.Insert(4);
      aList.Insert(2);
      DataStructures.LinkedList<int> bList = new DataStructures.LinkedList<int>();
      bList.Insert(9);
      bList.Insert(7);
      bList.Insert(5);
      bList.Insert(3);
      bList.Insert(1);
      Assert.NotEqual(10, DataStructures.LinkedList<int>.ZipLists(aList, bList).Value);
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
    /// <summary>
    /// Tests the List Creator method for a K-Ary tree
    /// </summary>
    [Fact]
    public void Test_Tree_List_Creator()
    {
      KAryTree<int> intTree = new KAryTree<int>(15);

      intTree.Root.Leaves.Add(new KAryNode<int>(30));
      intTree.Root.Leaves.Add(new KAryNode<int>(90));
      intTree.Root.Leaves.Add(new KAryNode<int>(5));

      intTree.Root.Leaves[0].Leaves.Add(new KAryNode<int>(10));

      intTree.Root.Leaves[1].Leaves.Add(new KAryNode<int>(33));

      intTree.Root.Leaves[2].Leaves.Add(new KAryNode<int>(7));
      intTree.Root.Leaves[2].Leaves.Add(new KAryNode<int>(60));

      List<int> testList = intTree.KAryTreeIteration(intTree.Root, intTree.ValueList);
      int[] expectedInts = new int[] { 15, 30, 10, 90, 33, 5, 7, 60 };

      Assert.Equal(expectedInts, testList.ToArray());

      }
    
    
    /// <summary>
    /// Test to see if the FizzBuzz Tree method will create a new tree with FizzBuzz
    /// divisible by 3 = "Fizz"
    /// divisible by 5 = "Buzz"
    /// divisible by 3 and 5 = "FizzBuzz
    /// Any other number = string equivalent (4 = "4")
    /// </summary>
    
    [Fact]
    public void Test_FizzBuzz_Tree()
    {
      //Setup of the integer Tree

      KAryTree<int> intTree = new KAryTree<int>(15);

      intTree.Root.Leaves.Add(new KAryNode<int>(30));
      intTree.Root.Leaves.Add(new KAryNode<int>(90));
      intTree.Root.Leaves.Add(new KAryNode<int>(5));

      intTree.Root.Leaves[0].Leaves.Add(new KAryNode<int>(10));

      intTree.Root.Leaves[1].Leaves.Add(new KAryNode<int>(33));

      intTree.Root.Leaves[2].Leaves.Add(new KAryNode<int>(7));
      intTree.Root.Leaves[2].Leaves.Add(new KAryNode<int>(60));

      //expected array of strings
      string[] expected = { "FizzBuzz","FizzBuzz","Buzz","FizzBuzz","Fizz", "Buzz", "7", "FizzBuzz" };
            
      //Running Method
      //intTree.KAryTreeIteration(intTree.Root, intTree.ValueList);
      
      KAryTree<string> fizzResult = FizzTreeMaker.FizzBuzzTree(intTree);
      fizzResult.KAryTreeIteration(fizzResult.Root, fizzResult.ValueList);

      Assert.Equal(expected, fizzResult.ValueList.ToArray());
    }
    [Fact]
    public void Find_Repeated_Word_In_String()
    {
      RepeatedWord repeatedWord = new RepeatedWord();
      //string testString = "Once upon a time, there was a brave princess who...";
      string testString = "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only...";
      string testValue = repeatedWord.FindRepeatedWord(testString);      
      Assert.Equal("IT", testValue);

    }
    [Fact]
    public void Find_No_Repeated_Word_In_String()
    {
      RepeatedWord repeatedWord = new RepeatedWord();
      string testString = "To boldly go where, no one has gone before";

      string testValue = repeatedWord.FindRepeatedWord(testString);
      Assert.Equal("", testValue);
    }
    [Fact]
    public void Find_No_Repeated_Word_In_Empty_String()
    {
      RepeatedWord repeatedWord = new RepeatedWord();
      string testString = "";

      string testValue = repeatedWord.FindRepeatedWord(testString);
      Assert.Equal("", testValue);
    }
    [Fact]
    public void Find_No_Repeated_Word_In_String_Of_Non_Word_Characters()
    {
      RepeatedWord repeatedWord = new RepeatedWord();
      string testString = "^%!#!@#$";

      string testValue = repeatedWord.FindRepeatedWord(testString);
      Assert.Equal("", testValue);
    }

  }
  }

