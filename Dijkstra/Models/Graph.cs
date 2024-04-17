namespace Dijkstra.Models;

public class Graph
{
    public List<Vertex> Vertices { get; }
    
    public Graph()
    {
        Vertices = new List<Vertex>();
    }
}