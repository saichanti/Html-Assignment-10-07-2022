
using System.Collections;

class Sorting
{

    public static void Main()
    {

        
        ArrayList mylist = new ArrayList();
        mylist.Add("Delhi");
        mylist.Add("Munbai");
        mylist.Add("Kolkata");
        mylist.Add("Chennai");

       


        Console.WriteLine("ArrayList after sort:");

       
        mylist.Sort();

        // ArrayList after sort
        foreach (string i in mylist)
        {
            Console.WriteLine(i);
        }
    }
}
