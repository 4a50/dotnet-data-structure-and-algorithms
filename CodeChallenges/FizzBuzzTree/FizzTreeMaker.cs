using System;

namespace FizzBuzzTree
{
  public static class FizzTreeMaker
  {
    /// <summary>
    /// This method sets up the conditions to iterate through a int K-Ary Tree and produce a "FizzBuzz" mirrored Tree
    /// 
    /// </summary>
    /// <param name="intTree"></param>
    /// <returns></returns>
    static public KAryTree<string> FizzBuzzTree(KAryTree<int> intTree)
    {
      intTree.FizzTree = new KAryTree<string>();
      intTree.FizzTree.Root = FizzBuzzIterate(intTree.Root, intTree.FizzTree.Root);
      return intTree.FizzTree;
    }
    /// <summary>
    /// FizzBuzzTree helper method.
    /// method that iterates through a given integer tree and produces a "FizzBuzz" tree.  
    /// </summary>
    /// <param name="intNode"></param>
    /// <param name="strNode"></param>
    /// <returns></returns>
    private static KAryNode<string> FizzBuzzIterate(KAryNode<int> intNode, KAryNode<string> strNode)
    {      
      strNode.Value = FizzBuzzConverter(intNode).Value;           

      for (int i = 0; i < intNode.Leaves.Count; i++)
      {        
        strNode.Leaves.Add(new KAryNode<string>());
        FizzBuzzIterate(intNode.Leaves[i], strNode.Leaves[i]);
      }
      return strNode;
    }
    /// <summary>
    /// FizzBuzzIterate Helper Method
    /// Determines the string value from an intedger input
    /// divisible by 3 = "Fizz"
    /// divisible by 5 = "Buzz"
    /// divisible by 3 and 5 = "FizzBuzz"
    /// Any other value is returned as a string ( 7 =  "7")
    /// </summary>
    /// <param name="intNode"></param>
    /// <returns></returns>
    private static KAryNode<string> FizzBuzzConverter(KAryNode<int> intNode)
    {
      KAryNode<string> kString = new KAryNode<string>();
      if (intNode.Value % 3 == 0 && intNode.Value % 5 == 0) { kString.Value = "FizzBuzz"; }
      else if (intNode.Value % 3 == 0) { kString.Value = "Fizz"; }
      else if (intNode.Value % 5 == 0) { kString.Value = "Buzz"; }
      else { kString.Value = intNode.Value.ToString(); }
      return kString;
    }
  }
}