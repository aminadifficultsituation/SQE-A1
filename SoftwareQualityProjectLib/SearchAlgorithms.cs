using System;

namespace SoftwareQualityProjectLib
{
    public class SearchAlgorithms
    {
        // Binary Search
        public int BinarySearch(int key, int[] arr)
        {
            int low = 0, high = arr.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (arr[mid] == key) return mid;
                if (arr[mid] < key) low = mid + 1;
                else high = mid - 1;
            }
            return -1; // not found
        }

        // Linear Search
        public int LinearSearch(int key, int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == key) return i;
            return -1;
        }

        // Jump Search
        public int JumpSearch(int key, int[] arr)
        {
            int n = arr.Length;
            int step = (int)Math.Floor(Math.Sqrt(n));
            int prev = 0;

            while (arr[Math.Min(step, n)-1] < key)
            {
                prev = step;
                step += (int)Math.Floor(Math.Sqrt(n));
                if (prev >= n) return -1;
            }

            for (int i = prev; i < Math.Min(step, n); i++)
                if (arr[i] == key) return i;

            return -1;
        }
    }
}
//meow
//testing