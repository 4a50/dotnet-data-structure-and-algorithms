using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTree
{
  public class KAryTree<T>
  {
    public KAryNode<T> Root { get; set; }
    public List<T> ValueList = new List<T>();
    public KAryTree<string> FizzTree {get; set;}
    public KAryTree() 
    {
      Root = new KAryNode<T>();
    }
    public KAryTree (T value)
    {
      Root = new KAryNode<T>(value);      
     }
    /// <summary>
    /// Will iterate through the tree and update the ValueList property will all the values in an pre-order manner.
    /// </summary>
    /// <param name="node"></param>
    /// <param name="valList"></param>
    /// <returns></returns>
    public List<T> KAryTreeIteration(KAryNode<T> node, List<T> valList)
    {
      valList.Add(node.Value);
      if (node.Leaves.Count == 0) { return valList; }
      foreach (KAryNode<T> t in node.Leaves)
      {
        KAryTreeIteration(t, valList);
      }
      return valList;
    }
  }
  
}


