namespace Dijkstra;

using Models;

public class GraphFactory
{
    public Graph CreateGraph()
    {
        var newGraph = new Graph();

        var vertexA = new Vertex("A");
        var vertexB = new Vertex("B");
        var vertexC = new Vertex("C");
        var vertexD = new Vertex("D");
        var vertexE = new Vertex("E");
        var vertexF = new Vertex("F");
        var vertexG = new Vertex("G");

        newGraph.Vertices.AddRange(new[] { vertexA, vertexB, vertexC, vertexD, vertexE, vertexF, vertexG });

        vertexA.Edges.Add(new Edge(vertexA, vertexB, 10));
        vertexA.Edges.Add(new Edge(vertexA, vertexD, 14));
        vertexA.Edges.Add(new Edge(vertexA, vertexC, 7));

        vertexB.Edges.Add(new Edge(vertexB, vertexA, 10));
        vertexB.Edges.Add(new Edge(vertexB, vertexD, 2));
        vertexB.Edges.Add(new Edge(vertexB, vertexE, 5));
        
        vertexC.Edges.Add(new Edge(vertexC, vertexA, 7));
        vertexC.Edges.Add(new Edge(vertexC, vertexD, 4));
        vertexC.Edges.Add(new Edge(vertexC, vertexF, 8));
        
        vertexD.Edges.Add(new Edge(vertexD, vertexA, 14));
        vertexD.Edges.Add(new Edge(vertexD, vertexB, 2));
        vertexD.Edges.Add(new Edge(vertexD, vertexC, 4));
        vertexD.Edges.Add(new Edge(vertexD, vertexE, 8));
        vertexD.Edges.Add(new Edge(vertexD, vertexF, 3));
        vertexD.Edges.Add(new Edge(vertexD, vertexG, 15));
        
        vertexE.Edges.Add(new Edge(vertexE, vertexB, 5));
        vertexE.Edges.Add(new Edge(vertexE, vertexD, 8));
        vertexE.Edges.Add(new Edge(vertexE, vertexG, 6));
        
        vertexF.Edges.Add(new Edge(vertexF, vertexC, 8));
        vertexF.Edges.Add(new Edge(vertexF, vertexD, 3));
        vertexF.Edges.Add(new Edge(vertexF, vertexG, 14));
        
        vertexG.Edges.Add(new Edge(vertexG, vertexD, 15));
        vertexG.Edges.Add(new Edge(vertexG, vertexE, 6));
        vertexG.Edges.Add(new Edge(vertexG, vertexF, 14));

        return newGraph;
    }
}