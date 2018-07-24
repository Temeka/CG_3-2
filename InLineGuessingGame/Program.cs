using System;

namespace InLineGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Guess the correct # to win, using an in line statement

            Console.Write("Guess and type a number between 1 and 10: ");
            string userValue = Console.ReadLine();

            //Using in line statement/operator, prompts the output based on 
            //if the option chosen is "true" or "false"

            string message = (userValue == "8") ? "You Win!" : "Sorry, you Lose.";

            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
