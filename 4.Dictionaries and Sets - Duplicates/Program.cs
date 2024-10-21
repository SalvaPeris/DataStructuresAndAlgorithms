internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("This is a demo for removing duplicates: ");

        List<string> names = new List<string>()
        {
            "Salva",
            "Mario",
            "Maria",
            "Pepe",
            "Alberto",
            "Emilio",
            "mario",
            "Jaime",
            "salva"
        };
        SortedSet<string> sorted = new SortedSet<string>(
            names,
            Comparer<string>.Create((a, b) => a.ToLower().CompareTo(b.ToLower())));

        foreach (string name in sorted)
        {
            Console.WriteLine(name);
        }
    }
}