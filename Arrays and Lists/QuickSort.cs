namespace Arrays_and_Lists
{
    public static class QuickSort
    {
        public static T[] Sort<T>(T[] array) where T : IComparable
        {
            var sortedArray = Sort(array, 0, array.Length - 1);
            return sortedArray;
        }

        private static T[] Sort<T>(T[] array, int lower, int upper) where T : IComparable
        {
            if (lower < upper)
            {
                int p = Partition(array, lower, upper);
                Sort(array, lower, p);
                Sort(array, p + 1, upper);
            }
            return array;
        }

        private static int Partition<T>(T[] array, int lower, int upper) where T: IComparable
        {
            int i = lower;
            int j = upper;

            T pivot = array[(lower + upper) / 2];

            do
            {
                while (array[i].CompareTo(pivot) < 0) { i++; }
                while (array[j].CompareTo(pivot) > 0) { j--; }
                if (i >= j) { break; }
                Utils.Swap(array, i, j);
            } while (i <= j);
            return j;
        }
    }
}
