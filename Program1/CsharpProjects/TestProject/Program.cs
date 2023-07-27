using System;

namespace CockroachFootNuke
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the three possible choices
            string[] choices = { "Cockroach", "Foot", "Nuke" };

            // Generate the computer's choice
            int computer = new Random().Next(1, 4);
            string computerChoice = choices[computer - 1];

            // Get the user's choice
            string userChoice = Console.ReadLine();

            // Compare the two choices
            if (userChoice == computerChoice)
            {
                Console.WriteLine("Tie!");
            }
            else if (userChoice == "Cockroach" && computerChoice == "Foot")
            {
                Console.WriteLine("You lose! Foot crushes cockroach.");
            }
            else if (userChoice == "Cockroach" && computerChoice == "Nuke")
            {
                Console.WriteLine("You win! Cockroach survives nuke.");
            }
            else if (userChoice == "Foot" && computerChoice == "Nuke")
            {
                Console.WriteLine("You lose! Nuke destroys foot.");
            }
            else if (userChoice == "Foot" && computerChoice == "Cockroach")
            {
                Console.WriteLine("You win! Foot stomps cockroach.");
            }
            else if (userChoice == "Nuke" && computerChoice == "Cockroach")
            {
                Console.WriteLine("You lose! Nuke kills cockroach.");
            }
            else
            {
                Console.WriteLine("You win! Nuke destroys foot.");
            }
        }
    }
}