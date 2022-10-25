using System;
using System.Linq;

namespace FindSumofPairInArray
{
    class Program
    {
        public bool findSumofPair(int[] arr, int sum)
        {
            int leftIndex = Array.IndexOf(arr, arr.Min());
            int rightIndex = Array.IndexOf(arr, arr.Max());

            while(leftIndex != rightIndex)
            {
                if (arr[leftIndex] + arr[rightIndex] > sum)
                    rightIndex = (arr.Length + rightIndex - 1) % arr.Length;// (N + r - 1) % N
                else if (arr[leftIndex] + arr[rightIndex] < sum)
                    leftIndex = (leftIndex + 1) % arr.Length;//(l+1) % N
                else if (arr[leftIndex] + arr[rightIndex] == sum)
                    return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            int[] arr = { 11, 15, 6, 6, 8, 9, 10 };
            int sum = 16;
            bool ans = program.findSumofPair(arr, sum);

            Console.WriteLine(ans);
        }
    }
}
