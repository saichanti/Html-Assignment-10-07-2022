using System;
namespace Program1
{
    class program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3,largest;
            Console.WriteLine("Enter number 1");
            n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 3");
            n3 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2 && n1 > n3)
                largest = n1;
            else if (n2 > n1 && n2 > n3)
                largest = n2;
            else
                largest = n3;
            Console.WriteLine(largest);
            
            
        }
    }
}
