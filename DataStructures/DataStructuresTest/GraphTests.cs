using DataStructures;
using Graphs;
using Xunit;
namespace DataStructuresTest
{
  public class GraphTesting
  {
    [Fact]
    public void Add_Node_To_Graph()
    {
      Graph<string> graph = new Graph<string>();
      graph.AddVertex("Duckberg");      
      Assert.True(graph.AdjecencyList.ContainsKey("Duckberg"));

    }
   
  }
}
