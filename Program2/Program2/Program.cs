using System;
namespace Program1
{
    class program
    {
        static void Main(string[] args)
        {
            //Boxing
            int i = 123; //valueType
            object o = i;//objecttype
            i = 456;

            System.Console.WriteLine("The value-type value = {0}", i);
            System.Console.WriteLine("The object-type value = {0}", o);

            //Unboxing
            int j = 123;
            object k = j;  // implicit boxing

            try
            {
                int m = (int)k;  // attempt to unbox

                System.Console.WriteLine("Unboxing OK.");
            }
            catch (System.InvalidCastException e)
            {
                System.Console.WriteLine("{0} Error: Incorrect unboxing.", e.Message);
            }


        }
    }
}
