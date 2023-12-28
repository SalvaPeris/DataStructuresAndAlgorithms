namespace Arrays_and_Lists
{
    public static class SelectionSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length - 1 ; i++)
            {
                int minIndex = i;
                T minValue = array[i];

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(minValue) < 0)
                    {
                        minIndex = j;
                        minValue = array[j];
                    }
                }
                Utils.Swap(array, i, minIndex);
            }
        }
    }
}
