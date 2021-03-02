using DataStructures;
using Graphs;
using System.Collections.Generic;
using Xunit;
namespace DataStructuresTest
{
  public class GraphTesting
  {
    [Fact]
    public void Add_Node_To_Graph()
    {
      Graph<string> graph = new Graph<string>();
      Vertex<string> testValue = graph.AddVertex("Duckberg");    
      Assert.True(graph.AdjecencyList.ContainsKey(testValue));
    }
    [Fact]
    public void Add_Edge_To_Graph()
    {
      Graph<string> graph = new Graph<string>();
      Vertex<string> vertA = graph.AddVertex("Duckberg");
      Vertex<string> vertB = graph.AddVertex("Cape Suzette");
      graph.AddDirectedEdge(vertA, vertB);

      bool test = false;
      foreach (Edge<string> edge in graph.AdjecencyList[vertA])
      {
        if (edge.Vertex.Value == "Cape Suzette") test = true;
      }
      Assert.True(test);
    }
    [Fact]
    public void Get_All_Nodes_From_A_Graph()
    {
      Graph<string> graph = new Graph<string>();
      Vertex<string> vertA = graph.AddVertex("Duckberg");
      Vertex<string> vertB = graph.AddVertex("Cape Suzette");
      Vertex<string> vertC = graph.AddVertex("St. Canard");

      List<string> listOfNodes = graph.GetNodes();      
      Assert.Contains("Duckberg", listOfNodes);
      Assert.Contains("Cape Suzette", listOfNodes);
      Assert.Contains("St. Canard", listOfNodes);
    }
    [Fact]
    public void Get_All_Neighbors_From_A_Graph()
    {
      Graph<string> graph = new Graph<string>();
      Vertex<string> vertA = graph.AddVertex("Duckberg");
      Vertex<string> vertB = graph.AddVertex("Cape Suzette");
      Vertex<string> vertC = graph.AddVertex("St. Canard");
      graph.AddDirectedEdge(vertA, vertB);
      graph.AddDirectedEdge(vertA, vertC);

      List<Edge<string>> testList = graph.GetNeighbors(vertA);
  
      Assert.Equal("Cape Suzette", testList[0].Vertex.Value);
      Assert.Equal("St. Canard", testList[1].Vertex.Value);
      
    }
    [Fact]
    public void Neighbors_Are_Returned_With_Weight()
    {
      Graph<string> graph = new Graph<string>();
      Vertex<string> vertA = graph.AddVertex("Duckberg");
      Vertex<string> vertB = graph.AddVertex("Cape Suzette");
      Vertex<string> vertC = graph.AddVertex("St. Canard");
      
      graph.AddDirectedEdge(vertA, vertB, 10);
      graph.AddDirectedEdge(vertA, vertC, 20);

      List<Edge<string>> testList = graph.GetNeighbors(vertA);

      Assert.Equal(10, testList[0].Weight);
      Assert.Equal(20, testList[1].Weight);            
    }
    [Fact]
    public void Proper_Size_Of_Graph_Is_Returned()
    {
      Graph<string> graph = new Graph<string>();
      Vertex<string> vertA = graph.AddVertex("Duckberg");
      Vertex<string> vertB = graph.AddVertex("Cape Suzette");
      Vertex<string> vertC = graph.AddVertex("St. Canard");

      Assert.Equal(3, graph.Size());
    }
    [Fact]
    public void Graph_With_One_Node()
    {
      Graph<string> graph = new Graph<string>();
      Vertex<string> vertA = graph.AddVertex("Duckberg");            
      Assert.Empty(graph.AdjecencyList[vertA]);
    }
    [Fact]
    public void Empty_Graph_Returns_A_Null()
    {
      Graph<string> graph = new Graph<string>();
      Assert.Null(graph.GetNodes());
    }

    
       
  }
}
