using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Linq
{
    public static void Main()
    {
        List<Students> studentList = new List<Students>()
              {
                 new Students(){Id=1,Name="Sai",Age=17},
                 new Students(){Id=2,Name="Hema",Age=21},
                 new Students(){Id=3,Name="vikas",Age=24},
                 new Students(){Id=4,Name="archana",Age=13},
                 new Students(){Id=5,Name="rocky",Age=50},
                 new Students(){Id=6,Name="Shyam",Age=15},
                 new Students(){Id=7,Name="Kiram",Age=14}

              };

        var list = studentList.Where(student => student.Age < 18).ToList();
        foreach (var student in list)
        {
            Console.WriteLine($"{student.Id} {student.Name} {student.Age}");
        }
    }
}
