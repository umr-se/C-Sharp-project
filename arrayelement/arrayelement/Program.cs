using System;

namespace arrayelement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++) {
                arr[i] = i;
            }
            for (int i = 0; i < 5; i++) {
                Console.WriteLine("Element[{0}] = {0}",i, arr[i]);
            }

        }
    }
}
