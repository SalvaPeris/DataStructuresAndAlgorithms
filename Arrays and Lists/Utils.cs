namespace Arrays_and_Lists
{
    public static class Utils
    {
        public static void Swap<T>(T[] array, int first, int second)
        {
            (array[second], array[first]) = (array[first], array[second]);
        }
    }
}
