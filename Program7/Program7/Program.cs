using System;

class ADD
{

    int a, b;
    

   
    public ADD(int x, int y) 
    {
        a = x;
        b = y;
    }

    
   

    public void show()
    {
        Console.WriteLine(" Constructor {0}", (a + b));

    }

 
}


class constructor
{

   
    static void Main()
    {

      
        ADD g = new ADD(10, 20);

      
        g.show();

       

    }
}
