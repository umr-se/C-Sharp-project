using System;

namespace min_no
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {4,2,3,1};
            int min = 1;
            for (int i = 0; i < 4; i++)
            {
                if (a[i] < min) {
                    min = a[i];
                }           
            }
            Console.WriteLine(min);
        }
    }
}
