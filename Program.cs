using System;

namespace RPS
{
    class Program
    {

        static void Main(string[] args)
        {
            Random rndm = new Random();
            int compChoice = rndm.Next(1, 4);
            Console.Clear();
            Console.WriteLine("Let's play Rock, Paper, Scissors!");
            Console.WriteLine("Please enter Rock, Paper, or Scissors");
            string playerChoice = Console.ReadLine().ToLower();
            while (playerChoice != "rock" && playerChoice != "paper" && playerChoice != "scissors")
            {
                System.Console.WriteLine("This is not a valid option");
                Console.WriteLine("Please select again!");
                playerChoice = Console.ReadLine().ToLower();
            }
            Console.WriteLine($"You selected {playerChoice}");
            string compChoiceString = "";
            if (compChoice == 0)
            {
                compChoiceString = "rock";
            }
            if (compChoice == 1)
            {
                compChoiceString = "paper";
            }
            if (compChoice == 2)
            {
                compChoiceString = "scissors";
            }

            Console.WriteLine($"The Computer selected {compChoiceString}");

            if (playerChoice == "rock")
            {
                if (compChoice == 0)
                {
                    Console.WriteLine("It's a tie!");
                }
                else if (compChoice == 1)
                {
                    Console.WriteLine("You Lose!");
                }
                else
                {
                    Console.WriteLine("You Win!");
                }
            }
            if (playerChoice == "paper")
            {
                if (compChoice == 0)
                {
                    Console.WriteLine("You Win!");
                }
                else if (compChoice == 1)
                {
                    Console.WriteLine("It's a tie!");
                }
                else
                {
                    Console.WriteLine("You Lose!");
                }
            }
            if (playerChoice == "scissors")
            {
                if (compChoice == 0)
                {
                    Console.WriteLine("You Lose!");
                }
                else if (compChoice == 1)
                {
                    Console.WriteLine("You Win!");
                }
                else
                {
                    Console.WriteLine("You Tie!");
                }
            }
        }

    }

}

