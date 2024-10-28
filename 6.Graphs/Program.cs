using _6.Graphs.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("This is a demo of graphs:");

        Graph<int> graph = new Graph<int>(true, true);

        Node<int> n1 = graph.AddNode(1);
        Node<int> n2 = graph.AddNode(2);
        Node<int> n3 = graph.AddNode(3);
        Node<int> n4 = graph.AddNode(4);
        Node<int> n5 = graph.AddNode(5);
        Node<int> n6 = graph.AddNode(6);
        Node<int> n7 = graph.AddNode(7);
        Node<int> n8 = graph.AddNode(8);

        graph.AddEdge(n1, n2, 9);
        graph.AddEdge(n1, n3, 5);
        graph.AddEdge(n2, n1, 3);
        graph.AddEdge(n2, n4, 18);
        graph.AddEdge(n3, n4, 12);
        graph.AddEdge(n4, n2, 2);
        graph.AddEdge(n4, n8, 8);
        graph.AddEdge(n5, n4, 9);
        graph.AddEdge(n5, n6, 2);
        graph.AddEdge(n5, n7, 5);
        graph.AddEdge(n5, n8, 3);
        graph.AddEdge(n6, n7, 1);
        graph.AddEdge(n7, n5, 4);
        graph.AddEdge(n7, n8, 6);
        graph.AddEdge(n8, n5, 3);

        Console.WriteLine("\n1. Depth-First Search:");
        List<Node<int>> dfsNodes = graph.DFS();
        dfsNodes.ForEach(n => Console.WriteLine(n));

        Console.WriteLine("\n\n2. Breadth-First Search:");
        List<Node<int>> bfsNodes = graph.BFS();
        bfsNodes.ForEach(n => Console.WriteLine(n));


    }
}