using System;

class Program 
{
     static void Main()
     {
        int x= 1;
        int y = 2;
        int z = 3;
        string s = "C";

        if (((x >= y) && (y < z)) || ((x < y) && (s == "C")))
        {
        if ( s == "C") 
          {
            Console.WriteLine("Success");
          }
          else 
          {
            Console.WriteLine("Error");
          }
        }
     }
}
