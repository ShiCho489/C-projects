using System;

namespace EligibleToVote
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for their age
            Console.WriteLine("Please add your age ");
            int age = int.Parse(Console.ReadLine());

            // Check if the user is eligible to vote
            if (age >= 18)
            {
                Console.WriteLine("You can cast your vote!");
            }
           
        }
    }
}
