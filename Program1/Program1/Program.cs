using System;
namespace Program1
{
    class program
    {
        static void Main( string[] args)
        {
            int[] arry = { 50, 65, 56, 71, 81 };
            int evencount=0, oddcount=0;
            for (int i=0; i < arry.Length; i++)
            {
                if (arry [i]%2==0)
                {
                    Console.WriteLine ("{0} is an even number",arry[i] );
                    evencount++;
                }
                else
                {
                    Console.WriteLine("{0} is odd number", arry[1]);
                    oddcount++;
                }
                Console.WriteLine("even={0}", evencount);
                Console.WriteLine("odd={0}", oddcount);
            }
        }
    }
}
