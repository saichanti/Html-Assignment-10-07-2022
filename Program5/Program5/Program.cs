using System;

namespace MethodOverload
{

    class Program
    {

        
        void FirstDisplay(int a)// method with one parameter
        {
            Console.WriteLine("Parameter: " + a);
        }

       
        void SecondDisplay(int a, int b) // method with two parameters
        {
            Console.WriteLine("Parameter: " + a + " and " + b);
        }
        static void Main(string[] args)
        {

            Program program = new Program();
            program.FirstDisplay(100);
            program.SecondDisplay(100, 200);
            Console.ReadLine();
        }
    }
}

