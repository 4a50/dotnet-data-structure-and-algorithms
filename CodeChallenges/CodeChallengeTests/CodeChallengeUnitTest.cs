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
    public void List_Of_Common_Values_In_Two_Trees() 
    {
      Trees.BinaryTree<int> btOne = new Trees.BinaryTree<int>(150);
      btOne.Root.Left = new Node<int>(100);
      btOne.Root.Left.Left = new Node<int>(75);
      btOne.Root.Left.Right = new Node<int>(160);

      btOne.Root.Left.Right.Left = new Node<int>(125);
      btOne.Root.Left.Right.Right = new Node<int>(175);

      btOne.Root.Right = new Node<int>(250);
      btOne.Root.Right.Left = new Node<int>(200);
      btOne.Root.Right.Right = new Node<int>(350);

      btOne.Root.Right.Right.Left = new Node<int>(300);
      btOne.Root.Right.Right.Right = new Node<int>(500);

      Trees.BinaryTree<int> btTwo = new Trees.BinaryTree<int>(42);

      btTwo.Root.Left = new Node<int>(100);
      btTwo.Root.Left.Left = new Node<int>(15);
      btTwo.Root.Left.Right = new Node<int>(100);

      btTwo.Root.Left.Right.Left = new Node<int>(125);
      btTwo.Root.Left.Right.Right = new Node<int>(175);

      btTwo.Root.Right = new Node<int>(600);
      btTwo.Root.Right.Left = new Node<int>(200);
      btTwo.Root.Right.Right = new Node<int>(350);

      btTwo.Root.Right.Right.Left = new Node<int>(4);
      btTwo.Root.Right.Right.Right = new Node<int>(500);



    }
  }
}

