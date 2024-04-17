
using Dijkstra;
using Dijkstra.Models;

/*
 * Алгоритм Дейкстры — это алгоритм на графах, который был разработан Эдсгером Дейкстрой в 1959 году.
 * Он позволяет вычислить кратчайший путь от одной изначально выбранной вершины до всех остальных вершин в графе
 * с неотрицательными весами ребер. Алгоритм примечателен тем, что он гарантирует нахождение оптимального решения.
 * Аналогия для понимания: представьте, что вы находитесь в центре города и хотите найти кратчайший путь до всех
 * достопримечательностей, при этом зная расстояние между каждым из объектов. Алгоритм Дейкстры позволит вам оптимально
 * спланировать маршрут.
 */

var factory = new GraphFactory();
var impl = new Implementations();
var newGraph = factory.CreateGraph();
var shortestPaths = impl.DijkstraAlgorithmSimple(newGraph, newGraph.Vertices.First());

foreach (var path in shortestPaths)
{
    Console.WriteLine($"Shortest path to {path.Key.Name}: {path.Value}");
}

/*
 * 1. Назначается начальная вершина, и для неё расстояние до себя устанавливается равным нулю, а до всех остальных вершин — бесконечность.
 * 2. Выбирается вершина с наименьшим временным расстоянием, которое еще не было посещено.
 * 3. Обновляются расстояния до соседних вершин.
 * 4. Вершина помечается как посещенная.
 * 5. Шаги 2-4 повторяются, пока не будут посещены все вершины.
 */
Dictionary<Vertex, int> DijkstraAlgorithm(Graph graph, Vertex source)
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