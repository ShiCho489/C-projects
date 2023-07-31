using System;
using System.IO;

public class Program
{
    static void Main(string[] args)
    {
		string fileName, content;
        // Check if a command line argument was provided
        if (args.Length == 0)
        {
            Console.WriteLine("No filename provided!");
        }
        else
        {
            // Get the filename from the command line argument
            fileName = args[0];

            // Check if the file exists
            if (File.Exists(fileName))
            {
                // Read the content of the file
                content = File.ReadAllText(fileName);

                // Print the content of the file to the console
                Console.WriteLine(content);
            }
            else
            {
                // The file does not exist
                Console.WriteLine("File does not exist!");
            }
        }
    }
}