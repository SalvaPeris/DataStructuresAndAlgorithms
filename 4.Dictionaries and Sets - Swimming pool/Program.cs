using _4.Dictionaries_and_Sets___Swimming_pool;

internal class Program
{
    private static Random random = new Random();

    static void Main(string[] args)
    {
        Dictionary<PoolType, HashSet<int>> tickets = new Dictionary<PoolType, HashSet<int>>()
            {
                { PoolType.RECREATION, new HashSet<int>() },
                { PoolType.COMPETITION, new HashSet<int>() },
                { PoolType.THERMAL, new HashSet<int>() },
                { PoolType.KIDS, new HashSet<int>() }
            };

        for (int i = 1; i < 100; i++)
        {
            foreach (KeyValuePair<PoolType, HashSet<int>> type in tickets)
            {
                if (GetRandomBoolean())
                {
                    type.Value.Add(i);
                }
            }
        }

        Console.WriteLine("Number of visitors by a pool type:");
        foreach (KeyValuePair<PoolType, HashSet<int>> type in tickets)
        {
            Console.WriteLine($" - {type.Key.ToString().ToLower()}: {type.Value.Count}");
        }

        PoolType maxVisitors = tickets
            .OrderByDescending(t => t.Value.Count)
            .Select(t => t.Key)
            .FirstOrDefault();
        Console.WriteLine($"Pool '{maxVisitors.ToString().ToLower()}' was the most popular.");

        HashSet<int> any = new HashSet<int>(tickets[PoolType.RECREATION]);
        any.UnionWith(tickets[PoolType.COMPETITION]);
        any.UnionWith(tickets[PoolType.THERMAL]);
        any.UnionWith(tickets[PoolType.KIDS]);
        Console.WriteLine($"{any.Count} people visited at least one pool.");

        HashSet<int> all = new HashSet<int>(tickets[PoolType.RECREATION]);
        all.IntersectWith(tickets[PoolType.COMPETITION]);
        all.IntersectWith(tickets[PoolType.THERMAL]);
        all.IntersectWith(tickets[PoolType.KIDS]);
        Console.WriteLine($"{all.Count} people visited all pools.");

        Console.WriteLine("RECREATION: " + string.Join(" ", tickets[PoolType.RECREATION]));
        Console.WriteLine("COMPETITION: " + string.Join(" ", tickets[PoolType.COMPETITION]));
        Console.WriteLine("THERMAL: " + string.Join(" ", tickets[PoolType.THERMAL]));
        Console.WriteLine("KIDS: " + string.Join(" ", tickets[PoolType.KIDS]));
    }

    private static bool GetRandomBoolean()
    {
        return random.Next(2) == 1;
    }
}