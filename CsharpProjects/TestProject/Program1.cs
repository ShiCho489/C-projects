using System;

namespace MenuExample
{
    class Program 
    {

   
    static void Main(string[] args)
    {
       //print a menu
      Console.WriteLine("Please select: ");
      Console.WriteLine("1) Water");
      Console.WriteLine("2) Juice");
      Console.WriteLine("3) Lemon");
      Console.WriteLine("4) Quit");

      //get the user input
      int select = int.Parse(Console.ReadLine());

      //switch on the user's input
      switch(select)
      {
        case 1:
          Console.WriteLine(" you selected Water");
          break;
        case 2: 
           Console.WriteLine("you selected Juice");
           break;
        case 3: 
           Console.WriteLine("you selected Lemon");
           break;
        case 4: 
           Console.WriteLine("Quit");
           break;
        default: 
           Console.WriteLine("Invalid selection.");
           break;
      }
      }
    }
      
}