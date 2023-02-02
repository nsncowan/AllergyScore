using System;
using System.Collections.Generic;
using AllergyScore.Models;

namespace AllergyScore {
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Please enter a number");
      string userInput = Console.ReadLine();
      if (userInput == "0")
      {
        Console.WriteLine("Please enter a larger number.");
      }
      else
      {
        Score test = new Score(userInput);
        List<string> testList = test.AllergyLoop();
        foreach(string x in testList) 
        {
          Console.WriteLine(x);
        }
      }
    }
  }
}