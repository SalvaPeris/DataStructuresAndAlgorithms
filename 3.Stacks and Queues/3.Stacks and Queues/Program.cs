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
    }
}