# Data Structure Implementations

## Graphs
Creation and manipulation of a Graph Data Structure

### Challenge

Create a Graph

### Approach & Efficiency
Time: O(n)
Space: O(n)

### API

AddVertex(T value)

AddDirectedEdge (Vertex&lt;T&gt; a, Vertex&lt;T&gt; b, int weight) - Edge from a -> b.  Can set weight (default = 0)

AddUndirectedEdge (Vertex&lt;T&gt; a, Vertex&lt;T&gt; b, int weight) - Edge from a -> b and from b -> a.  Can set weight (default = 0)

GetNeighbors(Vertex&lt;T&gt; a) - Returns All neighbors to Vertex a

GetNodes() - Returns a list of all Vertices in the Graph.  Returns *NULL* if empty

Size() - Returns an *int*  of the number of Vertices in the graph

Print() - Returns a Graphical representation of the Graph to the console.

