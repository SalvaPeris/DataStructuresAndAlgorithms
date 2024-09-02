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
/*internal class Program
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
}*/

// PROGRAM FOR CALL CENTER MANY CONSULTANTS

/*internal class Program
{
    static void Main(string[] args)
    {
        CallCenter center = new CallCenter();
        Parallel.Invoke(
            () => CallersAction(center),
            () => ConsultantAction(center, "Marcin", ConsoleColor.Red),
            () => ConsultantAction(center, "James", ConsoleColor.Yellow));
    }

    private static void CallersAction(CallCenter center)
    {
        Random rnd = new Random();
        while (true)
        {
            int clientId = rnd.Next(1, 10000);
            int waitingCount = center.Call(clientId);
            Console.WriteLine($"Incoming call from {clientId}, waiting in the queue: {waitingCount}");
            Thread.Sleep(rnd.Next(1000, 5000));
        }
    }

    private static void ConsultantAction(CallCenter center, string name, ConsoleColor color)
    {
        Random rand = new Random();
        while (true)
        {
            IncomingCall call = center.Answer(name);
            if(call != null)
            {
                Console.ForegroundColor = color;
                Console.WriteLine($"Call {call.Id} from {call.ClientId} is answered by {call.Consultant}");

                Console.ForegroundColor = ConsoleColor.Gray;
                Thread.Sleep(rand.Next(1000, 10000));
                center.End(call);

                Console.ForegroundColor = color;
                Console.WriteLine($"Call {call.Id} from {call.ClientId} is ended by {call.Consultant}");
                Console.ForegroundColor = ConsoleColor.Gray;

                Thread.Sleep(rand.Next(500, 1000));
            }
            else
            {
                Thread.Sleep(100);
            }
        }
    }
}*/

//PROGRAM FOR CALL CENTER ONE CONSULTANT WITH PRIORITY
internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();

        CallCenter center = new CallCenter();
        center.Call(1234);
        center.Call(5678, true);
        center.Call(1468);
        center.Call(9641, true);

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