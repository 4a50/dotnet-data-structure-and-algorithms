﻿using DataStructures;
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
    public Vertex<T> AddVertex(T value)
    {
      Vertex<T> node = new Vertex<T>(value);
      AdjecencyList.Add(node, new List<Edge<T>>());
      _size++;
      return node;
    }
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
    public void AddUndirectedEdge(Vertex<T> a, Vertex<T> b)
    {
      AddDirectedEdge(a, b);
      AddDirectedEdge(b, a);
    }
    public List<Edge<T>> GetNeighbors(Vertex<T> a)
    {
      return AdjecencyList[a];
    }
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
    public int Size()
    {
      return _size;
    }
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
