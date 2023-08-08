using System;

namespace practise
{
    class Program
    {
        static void Main(string[] args)
        {         
            int[] arr = { 99, 95, 93, 89, 87 };
            int max = arr[0];
            for (int i = 0; i < 4; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine(max);
        }
    }
}
