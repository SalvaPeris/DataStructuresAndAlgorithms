using _3.Stacks_and_Queues.CallCenter;
using _3.Stacks_and_Queues.HanoiTower;
using System.Reflection.Metadata.Ecma335;

// PROGRAM FOR HANOI TOWER
/*internal class Program
{
    private const int DISCS_COUNT = 3;

    private static void Main(string[] args)
    {
        HanoiTower algorithm = new HanoiTower(DISCS_COUNT);
        algorithm.MoveCompleted += algorithm.AlgorithmVisualize;
        algorithm.AlgorithmVisualize(algorithm, EventArgs.Empty);
        algorithm.Start();

        //MoveTest(DISCS_COUNT, "F", "T", "A");
    }

    public static void MoveTest(int discs, string from, string to, string auxiliary)
    {
        if (discs > 0)
        {
            MoveTest(discs - 1, from, auxiliary, to);
                Console.WriteLine(from + " -> " + to);
            MoveTest(discs - 1, auxiliary, to, from);
        }
    }
}*/

//PROGRAM FOR CALL CENTER ONE CONSULTANT
internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();

        CallCenter center = new CallCenter();
        center.Call(1234);
        center.Call(5678);
        center.Call(1468);
        center.Call(9641);

        while (center.AreWaitingCalls())
        {
            IncomingCall call = center.Answer("Marcin");
            Log($"Call #{call.Id} from {call.ClientId} is answered by {call.Consultant}");
            Thread.Sleep(random.Next(1000, 10000));
            center.End(call);
            Log($"Call #{call.Id} from {call.ClientId} is ended by {call.Consultant}");
        }
    }

    private static void Log(string text)
    {
        Console.WriteLine($"[{DateTime.UtcNow.ToString("HH:mm:ss")}]   {text}");
    }
}