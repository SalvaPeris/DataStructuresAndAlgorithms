namespace Trees___Binary_trees.Models
{
    public class BinaryTree<T>
    {
        public BinaryTreeNode<T> Root { get; set; }
        public int Count { get; set; }

        public List<BinaryTreeNode<T>> Traverse(TraversalType mode)
        {
            List<BinaryTreeNode<T>> nodes = new List<BinaryTreeNode<T>>();
            switch (mode)
            {
                case TraversalType.PREORDER:
                    TraversePreOrder(Root, nodes);
                    break;
                case TraversalType.INORDER:
                    TraverseInOrder(Root, nodes);
                    break;
                case TraversalType.POSTORDER:
                    TraversePostOrder(Root, nodes);
                    break;
            }
            return nodes;
        }

        private void TraversePreOrder(BinaryTreeNode<T> node, List<BinaryTreeNode<T>> result)
        {
            if (node != null)
            {
                result.Add(node);
                TraversePreOrder(node.Left, result);
                TraversePreOrder(node.Right, result);
            }
        }

        private void TraverseInOrder(BinaryTreeNode<T> node, List<BinaryTreeNode<T>> result)
        {
            if (node != null)
            {
                TraverseInOrder(node.Left, result);
                result.Add(node);
                TraverseInOrder(node.Right, result);
            }
        }

        private void TraversePostOrder(BinaryTreeNode<T> node, List<BinaryTreeNode<T>> result)
        {
            if (node != null)
            {
                TraversePostOrder(node.Left, result);
                TraversePostOrder(node.Right, result);
                result.Add(node);
            }
        }

        public int GetHeight()
        {
            int height = 0;
            foreach (BinaryTreeNode<T> node in Traverse(TraversalType.PREORDER))
                height = Math.Max(height, node.GetHeight());
            return height;
        }
    }
}
