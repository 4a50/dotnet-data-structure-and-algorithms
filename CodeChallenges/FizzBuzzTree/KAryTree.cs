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


