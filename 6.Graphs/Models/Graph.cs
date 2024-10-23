namespace _6.Graphs.Models
{
    public class Graph<T>
    {
        private bool _isDirected = false;
        private bool _isWeighted = false;
        public List<Node<T>> Nodes { get; set; } = new List<Node<T>>();

        public Edge<T> this[int from, int to]
        {
            get
            {
                Node<T> nodeFrom = Nodes[from];
                Node<T> nodeTo = Nodes[to];
                int i = nodeFrom.Neighbors.IndexOf(nodeTo);
                if (i >= 0)
                {
                    Edge<T> edge = new Edge<T>()
                    {
                        From = nodeFrom,
                        To = nodeTo,
                        Weight = i < nodeFrom.Weights.Count ? nodeFrom.Weights[i] : 0
                    };
                    return edge;
                }

                return null;
            }
        }

        public Graph(bool isDirected, bool isWeighted)
        {
            _isDirected = isDirected;
            _isWeighted = isWeighted;
        }

        public Node<T> AddNode(T value)
        {
            Node<T> node = new Node<T>() { Data = value };
            Nodes.Add(node);
            UpdateIndices();
            return node;
        }

        public void RemoveNode(Node<T> nodeToRemove)
        {
            Nodes.Remove(nodeToRemove);
            UpdateIndices();
            foreach (Node<T> node in Nodes)
                RemoveEdge(node, nodeToRemove);
        }

        public void AddEdge(Node<T> from, Node<T> to, int weight = 0)
        {
            from.Neighbors.Add(to);
            if (_isWeighted)
                from.Weights.Add(weight);

            if (!_isDirected)
            {
                to.Neighbors.Add(from);
                if (_isWeighted)
                    to.Weights.Add(weight);
            }
        }

        public void RemoveEdge(Node<T> from, Node<T> to)
        {
            int index = from.Neighbors.FindIndex(n => n == to);
            if (index >= 0)
            {
                from.Neighbors.RemoveAt(index);
                from.Weights.RemoveAt(index);
            }
        }

        public List<Edge<T>> GetEdges()
        {
            List<Edge<T>> edges = new List<Edge<T>>();
            foreach (Node<T> from in Nodes)
            {
                for (int i = 0; i < from.Neighbors.Count; i++)
                {
                    Edge<T> edge = new Edge<T>()
                    {
                        From = from,
                        To = from.Neighbors[i],
                        Weight = i < from.Weights.Count ? from.Weights[i] : 0
                    };
                    edges.Add(edge);
                }
            }
            return edges;
        }

        private void UpdateIndices()
        {
            int i = 0;
            Nodes.ForEach(n => n.Index = i++);
        }

        #region Traversal
        public List<Node<T>> DFS()
        {
            bool[] isExplored = new bool[Nodes.Count];
            List<Node<T>> result = new List<Node<T>>();
            DFS(isExplored, Nodes[0], result);
            return result;
        }

        private void DFS(bool[] isExplored, Node<T> node, List<Node<T>> result)
        {
            result.Add(node);
            isExplored[node.Index] = true;

            foreach (Node<T> neighbor in node.Neighbors)
                if (!isExplored[neighbor.Index])
                    DFS(isExplored, neighbor, result);
        }
        #endregion
    }
}