using System.Collections.Generic;
using Trees;
using Xunit;
namespace DataStructuresTest
{
  public class TreeTesting
  {
    [Fact]
    public void Test_PreOrder_Traversal_Of_Binary_Tree_Success()
    {
      BinaryTree<int> bt = new BinaryTree<int>(756);
      bt.Root.Left.Value = 752;
      bt.Root.Left.Left.Value = 2;
      bt.Root.Left.Right.Value = 743;

      bt.Root.Right.Value = 705;
      bt.Root.Right.Left.Value = 81;
      bt.Root.Right.Right.Value = 22;

      int[] testArray = new int[] { 756, 752, 2, 743, 705, 81, 22 };
      Assert.Equal(testArray, bt.PreOrder(bt.Root, new List<int>()));

    }


  }
}
