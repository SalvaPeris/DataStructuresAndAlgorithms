using Arrays_and_Lists;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("This is Arrays and Lists demostration");

        Console.WriteLine("Selection Sort with numbers:");
        int[] numberValues = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
        SelectionSort.Sort(numberValues);
        Console.WriteLine(string.Join(", ", numberValues));

        Console.WriteLine("Selection Sort with names:");
        string[] namesValues = { "Salva", "Pepe", "Juan", "Luisa", "María", "Pepa" };
        SelectionSort.Sort(namesValues);
        Console.WriteLine(string.Join(", ", namesValues));
    }
}