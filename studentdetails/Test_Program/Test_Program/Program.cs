using System;

namespace Test_Program 
{


     class Program
    {
        static void Main(string[] arg)
        {
            student s1 = new student("UMER");
            Console.WriteLine(s1.name);
            Console.WriteLine(s1.Forcheck());
            Console.WriteLine(s1.program);
            


           

            Console.ReadLine();        
        }
    }
}
