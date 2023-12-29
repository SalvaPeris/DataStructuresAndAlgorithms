using Arrays_and_Lists.SortingAlgorithms;

internal class Program
{
    private static void Main()
    {
        Console.WriteLine("This is Arrays and Lists demostration");
        int[] numberValues = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
        string[] namesValues = { "Salva", "Pepe", "Juan", "Luisa", "María", "Pepa" };


        Console.WriteLine("Selection Sort with numbers:");
        int[] selectionSortNumberValues = (int[])numberValues.Clone();
        SelectionSort.Sort(selectionSortNumberValues);
        Console.WriteLine(string.Join(", ", selectionSortNumberValues));

        Console.WriteLine("Selection Sort with names:");
        string[] selectionSortNamesValues = (string[])namesValues.Clone();
        SelectionSort.Sort(selectionSortNamesValues);
        Console.WriteLine(string.Join(", ", selectionSortNamesValues));

        Console.WriteLine();

        Console.WriteLine("Insertion Sort with numbers:");
        int[] insertionSortNumberValues = (int[])numberValues.Clone();
        InsertionSort.Sort(insertionSortNumberValues);
        Console.WriteLine(string.Join(", ", insertionSortNumberValues));

        Console.WriteLine("Insertion Sort with names:");
        string[] insertionSortNamesValues = (string[])namesValues.Clone();
        InsertionSort.Sort(insertionSortNamesValues);
        Console.WriteLine(string.Join(", ", insertionSortNamesValues));

        Console.WriteLine();

        Console.WriteLine("Bubble Sort with numbers:");
        int[] bubbleSortNumberValues = (int[])numberValues.Clone();
        BubbleSort.Sort(bubbleSortNumberValues);
        Console.WriteLine(string.Join(", ", bubbleSortNumberValues));

        Console.WriteLine("Bubble Sort with names:");
        string[] bubbleSortNamesValues = (string[])namesValues.Clone();
        BubbleSort.Sort(bubbleSortNamesValues);
        Console.WriteLine(string.Join(", ", bubbleSortNamesValues));

        Console.WriteLine();

        Console.WriteLine("Quick Sort with numbers:");
        int[] quickSortNumberValues = (int[])numberValues.Clone();
        QuickSort.Sort(quickSortNumberValues);
        Console.WriteLine(string.Join(", ", quickSortNumberValues));
    }
}