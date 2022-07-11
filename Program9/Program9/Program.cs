using System;
using System.Collections;
using System.Collections.Generic;

class Cricket
{

        static void Main()
        {

            Dictionary<string, Int16> CricketerList = new Dictionary<string, Int16>();
            CricketerList.Add("saikumar", 23);
            CricketerList.Add("Venky", 25);
            CricketerList.Add("Praveen ", 29);
            CricketerList.Add("Raj", 21);
            CricketerList.Add("ramesh", 24);
            CricketerList.Add("kumar", 23);
            CricketerList.Add("Vetesh", 25);
            CricketerList.Add("virat ", 29);
            CricketerList.Add("Rajkumar", 21);
            CricketerList.Add("ramesh mo", 84);
        CricketerList.Add("rathod", 34);

        Console.WriteLine("cricketers List");
            foreach (KeyValuePair<string, Int16> cricketer in CricketerList)
            {
                Console.WriteLine("Key: {0}, Value: {1}", cricketer.Key, cricketer.Value);
            }
        }
    }

