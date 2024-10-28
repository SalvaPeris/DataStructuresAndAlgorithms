using _6.Graphs.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("This is a demo for showing how colors can be in Poland Map: ");
        Graph<string> graph = new Graph<string>(false, false);

        Node<string> nodePK = graph.AddNode("PK");
        Node<string> nodeLU = graph.AddNode("LU");
        Node<string> nodePD = graph.AddNode("PD");
        Node<string> nodeWM = graph.AddNode("WM");
        Node<string> nodeMZ = graph.AddNode("MZ");
        Node<string> nodeSW = graph.AddNode("SK");
        Node<string> nodeMA = graph.AddNode("MA");
        Node<string> nodeSL = graph.AddNode("SL");
        Node<string> nodeLD = graph.AddNode("LD");
        Node<string> nodeKP = graph.AddNode("KP");
        Node<string> nodePM = graph.AddNode("PM");
        Node<string> nodeZP = graph.AddNode("ZP");
        Node<string> nodeWP = graph.AddNode("WP");
        Node<string> nodeLB = graph.AddNode("LB");
        Node<string> nodeDS = graph.AddNode("DS");
        Node<string> nodeOP = graph.AddNode("OP");

        graph.AddEdge(nodePK, nodeLU);
        graph.AddEdge(nodePK, nodeSW);
        graph.AddEdge(nodePK, nodeMA);
        graph.AddEdge(nodeLU, nodeSW);
        graph.AddEdge(nodeLU, nodeMZ);
        graph.AddEdge(nodeLU, nodePD);
        graph.AddEdge(nodePD, nodeMZ);
        graph.AddEdge(nodePD, nodeWM);
        graph.AddEdge(nodeWM, nodeKP);
        graph.AddEdge(nodeWM, nodePM);
        graph.AddEdge(nodeWM, nodeMZ);
        graph.AddEdge(nodeMZ, nodeKP);
        graph.AddEdge(nodeMZ, nodeLD);
        graph.AddEdge(nodeMZ, nodeSW);
        graph.AddEdge(nodeSW, nodeLD);
        graph.AddEdge(nodeSW, nodeSL);
        graph.AddEdge(nodeSW, nodeMA);
        graph.AddEdge(nodeMA, nodeSL);
        graph.AddEdge(nodeSL, nodeOP);
        graph.AddEdge(nodeSL, nodeLD);
        graph.AddEdge(nodeLD, nodeOP);
        graph.AddEdge(nodeLD, nodeWP);
        graph.AddEdge(nodeLD, nodeKP);
        graph.AddEdge(nodeKP, nodeWP);
        graph.AddEdge(nodeKP, nodePM);
        graph.AddEdge(nodePM, nodeZP);
        graph.AddEdge(nodePM, nodeLB);
        graph.AddEdge(nodePM, nodeWP);
        graph.AddEdge(nodeZP, nodeLB);
        graph.AddEdge(nodeWP, nodeDS);
        graph.AddEdge(nodeWP, nodeOP);
        graph.AddEdge(nodeWP, nodeLB);
        graph.AddEdge(nodeLB, nodeDS);
        graph.AddEdge(nodeDS, nodeOP);

        int[] colors = graph.Color();
        for (int i = 0; i < colors.Length; i++)
        {
            Console.WriteLine($"{graph.Nodes[i].Data}: {colors[i]}");
        }

    }
}