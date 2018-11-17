using System;

namespace Fitness
{
  class Program
  {
    static void Main()
    {
      int runningTotal = 0;
      bool keepGoing = true;

      while (keepGoing)
      {
        // Prompt user for minutes exercised
        Console.WriteLine("Enter how many minutes you exercised: ");
        string entry = Console.ReadLine();

        // Add minutes exercised to total
        int minutes = int.Parse(entry);
        runningTotal = runningTotal + minutes;

        // Display total minutes exercised to the screen
        Console.WriteLine("You've entered " + runningTotal + " minutes.");

        //Repeat until user quits
      }

    }
  }
}