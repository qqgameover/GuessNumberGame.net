using System;

namespace guess_number_game
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToGuess = GenerateRandomNumber();
            Console.WriteLine("Guess a number 1-100");
            string guessedNumber = Console.ReadLine();
            AttemptToGuess(guessedNumber, numberToGuess);
        }
        static int GenerateRandomNumber()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 100);
            return randomNumber;
        }
        static void AttemptToGuess(string guessedNumber, int numberToGuess)
        {
            int guessedNumberInt = Int16.Parse(guessedNumber);
            if(guessedNumberInt != numberToGuess)
            {
                if(guessedNumberInt < numberToGuess)
                {
                    Console.WriteLine("The number you guessed was too low, try again");
                    string guessedNumberB = Console.ReadLine();
                    AttemptToGuess(guessedNumberB, numberToGuess);
                }
                else
                {
                    Console.WriteLine("The number you guessed was too high, try again");
                    string guessedNumberB = Console.ReadLine();
                    AttemptToGuess(guessedNumberB, numberToGuess);
                }
            }
            else if (guessedNumberInt == numberToGuess)
            {
                Console.WriteLine("You win!");
            }
        }
    }
}
