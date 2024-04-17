namespace Dijkstra.Models;

public class Vertex
{
    public string Name { get; }
    public List<Edge> Edges { get; }

    public Vertex(string name)
    {
        Name = name;
        Edges = new List<Edge>();
    }
}