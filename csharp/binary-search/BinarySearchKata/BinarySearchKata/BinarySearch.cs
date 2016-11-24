namespace BinarySearchKata
{
    public class BinarySearch
    {
        public static int Search(int[] array, int findNum)
        {
            if (array.Length == 0) return -1;
            return SearchBinary(array, 0, array.Length-1, findNum);
        }

        private static int SearchBinary(int[] array, int minIndex, int maxIndex, int findNumber)
        {
            var middleIndex = (minIndex + maxIndex) / 2;
            if (array[middleIndex] == findNumber)
                return middleIndex;
            if (middleIndex <= 0 || middleIndex >= array.Length - 1)
                return -1;
            if (array[middleIndex] > findNumber)
                return SearchBinary(array, minIndex, middleIndex - 1, findNumber);
            return SearchBinary(array, middleIndex + 1, maxIndex, findNumber);
        }

    }
}
