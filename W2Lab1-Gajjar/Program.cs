using System;

namespace W2Lab1_Gajjar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[7];
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]=random.Next(1,49);
            }
            Array.Sort(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
