using System.Collections.Generic;
using Trees;
using Xunit;
namespace DataStructuresTest
{
  public class TreeTesting
  {
    /// <summary>
    /// Proper Traversal of a Binary Tree using PreOrder Method
    /// </summary>
    [Fact]
    public void PreOrder_Traversal_Of_Binary_Tree_Success()
    {
      BinaryTree<int> bt = new BinaryTree<int>(756);
      bt.Root.Left = new Node<int>(752);
      bt.Root.Left.Left = new Node<int>(2);
      bt.Root.Left.Right = new Node<int>(743);

      bt.Root.Right = new Node<int>(705);
      bt.Root.Right.Left = new Node<int>(81);
      bt.Root.Right.Right = new Node<int>(22);

      int[] testArray = new int[] { 756, 752, 2, 743, 705, 81, 22 };
      Assert.Equal(testArray, bt.PreOrder(bt.Root, new List<int>()));

    }
    /// <summary>
    /// Proper Traversal of a Binary Tree using InOrder Method
    /// </summary>
    [Fact]
    public void InOrder_Traversal_Of_Binary_Tree_Success()
    {
      BinaryTree<int> bt = new BinaryTree<int>(756);
      bt.Root.Left = new Node<int>(752);
      bt.Root.Left.Left = new Node<int>(2);
      bt.Root.Left.Right = new Node<int>(743);

      bt.Root.Right = new Node<int>(705);
      bt.Root.Right.Left = new Node<int>(81);
      bt.Root.Right.Right = new Node<int>(22);

      int[] testArray = new int[] { 2, 752, 743, 756, 81, 705, 22 };
      Assert.Equal(testArray, bt.InOrder(bt.Root, new List<int>()));

    }
    /// <summary>
    /// Proper Traversal of a Binary Tree using PostOrder Method
    /// </summary>
    [Fact]
    public void PostOrder_Traversal_Of_Binary_Tree_Success()
    {
      BinaryTree<int> bt = new BinaryTree<int>(756);
      bt.Root.Left = new Node<int>(752);
      bt.Root.Left.Left = new Node<int>(2);
      bt.Root.Left.Right = new Node<int>(743);

      bt.Root.Right = new Node<int>(705);
      bt.Root.Right.Left = new Node<int>(81);
      bt.Root.Right.Right = new Node<int>(22);

      int[] testArray = new int[] { 2, 743, 752, 81, 22, 705, 756 };
      Assert.Equal(testArray, bt.PostOrder(bt.Root, new List<int>()));

    }
    /// <summary>
    /// Instantiation of an Empty Binary Tree.
    /// BinaryTree.Root == null
    /// </summary>
    [Fact]
    public void Instantiation_Of_Empty_Binary_Tree()
    {
      BinaryTree<int> bt = new BinaryTree<int>();
      Assert.Null(bt.Root);

    }
    /// <summary>
    /// Instantiates a single node in a Binary tree and runs pre-order and returns
    /// single value in the List.
    /// </summary>
    [Fact]
    public void Instantiation_Of_Single_Node_Binary_Tree()
    {
      BinaryTree<int> bt = new BinaryTree<int>(743);
      int[] testArr = new int[] { 743 };
      Assert.Equal(testArr, bt.PreOrder(bt.Root, new List<int>()));
    }
    /// <summary>
    /// Add a child to the left of the search tree value < Root
    /// </summary>
    [Fact]
    public void Add_Child_To_Left_Of_Root_Node()
    {
      BinarySearchTree bst = new BinarySearchTree(50);
      bst.Add(25);
      Assert.Equal(25, bst.Root.Left.Value);
    }
    /// <summary>
    /// Add a child to the right of the search tree value > Root
    /// </summary>
    [Fact]
    public void Add_Child_To_Right_Of_Root_Node()
    {
      BinarySearchTree bst = new BinarySearchTree(50);
      bst.Add(60);
      Assert.Equal(60, bst.Root.Right.Value);
    }
    /// <summary>
    /// Instantiates an empty Binary Search Tree
    /// </summary>
    [Fact]
    public void Instantiate_A_Binary_Search_Tree_With_No_Node()
    {
      BinarySearchTree bst = new BinarySearchTree();
      Assert.Null(bst.Root);
    }
    /// <summary>
    /// Instantiates a single not binary search tree
    /// </summary>
    [Fact]
    public void Instantiate_A_Binary_Search_Tree_With_One_Node()
    {
      BinarySearchTree bst = new BinarySearchTree(50);
      Assert.NotNull(bst.Root);
    }
    /// <summary>
    /// Locates a value in a Binary Search Tree
    /// </summary>
    [Fact]
    public static void Successfully_Locates_A_Value_In_Binary_Search_Tree()
    {
      BinarySearchTree bst = new BinarySearchTree(50);
      bst.Add(30);
      bst.Add(23);
      bst.Add(100);
      bst.Add(80);
      bst.Add(90);
      bst.Add(40);
      Assert.True(bst.Contains(40));
    }
    /// <summary>
    /// Does Not Locate a Value in a Binary Search Tree
    /// </summary>
    [Fact]
    public static void Does_Not_Locates_A_Value_In_Binary_Search_Tree()
    {
      BinarySearchTree bst = new BinarySearchTree(50);
      bst.Add(30);
      bst.Add(23);
      bst.Add(100);
      bst.Add(80);
      bst.Add(90);
      bst.Add(40);
      Assert.False(bst.Contains(200));
    }


  }
}
