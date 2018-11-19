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

        if(entry == "quit")
        {
          keepGoing = false;
        }
        else
        {
          try
          {

            // Add minutes exercised to total
            int minutes = int.Parse(entry);

            if(minutes <= 10)
            {
              Console.WriteLine("Better than nothing, am I right?");
            }
            else if(minutes <=30)
            {
              Console.WriteLine("Way to go!");
            }
            else if(minutes <=60)
            {
              Console.WriteLine("You must be a ninja warrior in training!");
            } 
            else
            {
              Console.WriteLine("Okay, now you're just showing off!");
            }

          runningTotal = runningTotal + minutes;
          }
          catch(FormatException)
          {
            Console.WriteLine("That is not a valid input.");
            continue;
          }

          // Display total minutes exercised to the screen
          Console.WriteLine("You've entered " + runningTotal + " minutes.");
        }
      
        //Repeat until user quits
      }
      Console.WriteLine("Goodbye");
    }
  }
}