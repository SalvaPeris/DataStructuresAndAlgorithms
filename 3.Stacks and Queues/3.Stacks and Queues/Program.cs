using _3.Stacks_and_Queues.HanoiTower;

internal class Program
{
    private const int DISCS_COUNT = 3;

    private static void Main(string[] args)
    {
        HanoiTower algorithm = new HanoiTower(DISCS_COUNT);
        algorithm.MoveCompleted += algorithm.AlgorithmVisualize;
        algorithm.AlgorithmVisualize(algorithm, EventArgs.Empty);
        algorithm.Start();

        Move(DISCS_COUNT, "F", "T", "A");
    }

    public static void Move(int discs, string from, string to, string auxiliary)
    {
        if (discs > 0)
        {
            Move(discs - 1, from, auxiliary, to);
            Console.WriteLine(from + " -> " + to);
            Move(discs - 1, auxiliary, to, from);
        }
    }
}