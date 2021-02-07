using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTree
{
  public class KAryNode<T>
  {
    public T Value { get; set; }
    public List<KAryNode<T>> Leaves { get; set; }
   public KAryNode() {
      Leaves = new List<KAryNode<T>>();
    }
    public KAryNode(T value)
    {
      Value = value;
       Leaves = new List<KAryNode<T>>();

    }
  }    
}
