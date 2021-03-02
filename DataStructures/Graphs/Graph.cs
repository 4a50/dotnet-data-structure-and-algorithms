using DataStructures;
using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
  public class Graph<T>
  {
    public Dictionary<Vertex<T>, List<Edge<T>>> AdjecencyList { get; set; }
    private int _size = 0;

    public Graph()
    {
      AdjecencyList = new Dictionary<Vertex<T>, List<Edge<T>>>();
    }
    /// <summary>
    /// Add a Vertex to the Graph
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public Vertex<T> AddVertex(T value)
    {
      Vertex<T> node = new Vertex<T>(value);
      AdjecencyList.Add(node, new List<Edge<T>>());
      _size++;
      return node;
    }
    /// <summary>
    /// Adds a Directed Edge from Vertex A to Vertex B in the graph
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="weight"></param>
    public void AddDirectedEdge(Vertex<T> a, Vertex<T> b, int weight = 0)
    {
      AdjecencyList[a].Add(
        new Edge<T>
        {
          Weight = weight,
          Vertex = b
        }
      );
    }
    /// <summary>
    /// Adds an Undirected Edge to two vertices
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    public void AddUndirectedEdge(Vertex<T> a, Vertex<T> b, int weight = 0)
    {
      AddDirectedEdge(a, b, weight);
      AddDirectedEdge(b, a, weight);
    }
    /// <summary>
    /// Lists all the neighbor nodes of a given Vertex
    /// </summary>
    /// <param name="a"></param>
    /// <returns></returns>
    public List<Edge<T>> GetNeighbors(Vertex<T> a)
    {
      return AdjecencyList[a];
    }
    /// <summary>
    /// Gets all nodes in the graph and returns the list
    /// </summary>
    /// <returns></returns>
    public List<T> GetNodes()
    {
      List<T> nodes = new List<T>();
      if (AdjecencyList.Count == 0) { return null; }
      foreach (var item in AdjecencyList)
      {
        nodes.Add(item.Key.Value);
      }      
      return nodes;
    }
    /// <summary>
    /// Returns the size of the graph
    /// </summary>
    /// <returns></returns>
    public int Size()
    {
      return _size;
    }
    /// <summary>
    /// Prints out a visual representation of the graph to the console.
    /// </summary>
    public void Print()
    {
      foreach (var item in AdjecencyList)
      {
        Console.Write($"Vertex {item.Key.Value} => ");
        foreach (var edge in item.Value)
        {
          Console.Write($"{edge.Vertex.Value} -> ");
        }
        Console.WriteLine();
      }
    }
  }
}
