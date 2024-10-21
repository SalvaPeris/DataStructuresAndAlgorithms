using SelfBalancedTree;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("This is a demo for keeping the tree balanced:");

        AVLTree<int> tree = new AVLTree<int>();
        for (int i = 1; i < 10; i++)
            tree.Add(i);

        Console.WriteLine("Get Height : " + string.Join(", ", tree.GetHeightLogN()));
        Console.WriteLine("Descending : " + string.Join(", ", tree.ValuesCollectionDescending));
        Console.WriteLine("Printing AVL tree:");
        tree.Print();
    }
}