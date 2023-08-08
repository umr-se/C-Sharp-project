using System;

namespace pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i; j++) {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
