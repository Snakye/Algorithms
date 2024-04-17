namespace Dijkstra;

using Models;

public class Implementations
{
    /*
     * 1. Назначается начальная вершина, и для неё расстояние до себя устанавливается равным нулю, а до всех остальных вершин — бесконечность.
     * 2. Выбирается вершина с наименьшим временным расстоянием, которое еще не было посещено.
     * 3. Обновляются расстояния до соседних вершин.
     * 4. Вершина помечается как посещенная.
     * 5. Шаги 2-4 повторяются, пока не будут посещены все вершины.
     */
    public Dictionary<Vertex, int> DijkstraAlgorithmSimple(Graph graph, Vertex source)
    {
        var distances = graph.Vertices.ToDictionary(v => v, _ => int.MaxValue);
        var notVisited = new HashSet<Vertex>(graph.Vertices);

        distances[source] = 0;

        while (notVisited.Any())
        {
            var nearestVertex = notVisited.MinBy(v => distances[v]);
            notVisited.Remove(nearestVertex);

            foreach (var edge in nearestVertex.Edges)
            {
                var neighbor = edge.To;
                if (notVisited.Contains(neighbor))
                {
                    var currentDistance = distances[nearestVertex] + edge.Weight;
                    if (currentDistance < distances[neighbor])
                    {
                        distances[neighbor] = currentDistance;
                    }
                }
            }
        }

        return distances;
    }
}