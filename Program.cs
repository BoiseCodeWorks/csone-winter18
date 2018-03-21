using System;
using System.Collections.Generic;
using System.Linq;

namespace csone
{
  class Program
  {
    static void Main(string[] args)
    {
      #region SANDBOX
      // System.Console.Clear();
      // Console.WriteLine("Hello User, what's your name?");
      // var myName = Console.ReadLine();
      // Console.WriteLine("Hello {0}, how's it going {0}?", myName);
      // string mood = Console.ReadLine();
      // if (mood == "good")
      // {
      //   Console.WriteLine("Glad to hear it!");
      // }
      // else if (mood == "bad")
      // {
      //   Console.WriteLine("Thats a bummer dude");
      // }
      // else
      // {
      //   System.Console.WriteLine("Whatever");
      // }
      // // Console.WriteLine($"How Old are you {myName}");
      // // string ageString = Console.ReadLine();
      // // float age = 0f;
      // // float.TryParse(ageString, out age);
      // // if (age != 0 && age > 21)
      // // {
      // //   Console.WriteLine("Yer old enough");
      // // }
      // // else
      // // {
      // //   Console.WriteLine("Not today Kid");
      // // }
      // bool playing = true;
      // Console.WriteLine("Do you want to play a game?");
      // string choice = Console.ReadLine().ToLower();
      // if (choice[0] == 'n')
      // {
      //   playing = false;
      // }
      // while (playing)
      // {
      //   Random rnd = new Random();
      //   int randomNumber = rnd.Next(1, 5);
      //   System.Console.WriteLine("Lets Play! Pick a number between 1 and 5");
      //   string guess = Console.ReadLine();
      //   int numberGuess;
      //   int.TryParse(guess, out numberGuess);
      //   if (numberGuess == randomNumber)
      //   {
      //     System.Console.WriteLine(" YOU WIN!!!! ");
      //   }
      // 	else
      // 	{
      // 		System.Console.WriteLine("HAHA U LOSE!");
      // 	}
      //   System.Console.WriteLine("Play Again?");
      //     string play = Console.ReadLine().ToLower();
      //     if (play[0] == 'n')
      //     {
      //       playing = false;
      //     }
      // }
      #endregion


      #region ROCK PAPER SCISSORS

      Console.Clear();
      //Outcomes has a key of choice and a value of what it beats
      Dictionary<string, string> outcomes = new Dictionary<string, string>();
      outcomes["rock"] = "scissors";
      outcomes["paper"] = "rock";
      outcomes["scissors"] = "paper";
      string[] choices = outcomes.Keys.ToArray();
      bool playing = true;


      Console.WriteLine("Would you like to Play Rock, Paper, Scissors?");
      string play = Console.ReadLine().ToLower();
      if (play[0] == 'n')
      {
        Console.WriteLine("Ok goodbye!");
        playing = false;
      }
      else
      {
        Console.WriteLine("Great!");
      }
      while (playing)
      {
        Random rnd = new Random();
        string compChoice = choices[rnd.Next(3)];
        bool valid = false;
        string playerChoice = "";
        System.Console.WriteLine("Choose from Rock, Paper, or Scissors");
        while (!valid)
        {
          playerChoice = Console.ReadLine().ToLower();
          System.Console.WriteLine("You chose : " + playerChoice);
          if (playerChoice != "rock" && playerChoice != "scissors" && playerChoice != "paper")
          {
            System.Console.WriteLine("Please make a valid selection");
          }
          else
          {
            valid = true;
          }
        }
        System.Console.WriteLine("but I chose {0}", compChoice);
        if (playerChoice == compChoice)
        {
          Console.WriteLine("It's a Tie!");
        }
        else if (outcomes[playerChoice] == compChoice)
        {
          Console.WriteLine("You Win!");
        }
        else
        {
          Console.WriteLine("It seems you have lost");
        }
        System.Console.WriteLine("Play Again? (Y/N) :");
        string again = Console.ReadLine();
        if (again[0] == 'n')
        {
          Console.WriteLine("Ok goodbye!");
          playing = false;
        }
        else
        {
          Console.Clear();
          Console.WriteLine("Great!");

        }
      }




      #endregion

    }
  }
}
