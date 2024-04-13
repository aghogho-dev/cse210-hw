using System;

namespace Prep3
{
    class Program
    {
        static void Main(string[] args)
        {
            string play = "yes";

            do
            {
                Random randomNumber = new Random();
                int magicNumber = randomNumber.Next(1, 101);
                Console.WriteLine("\nComputer has generated a magic number. Can you guess it?\n");

                int guessNumber, count = 0;

                do {
                    Console.Write("What is your guess? ");
                    string guess = Console.ReadLine();
                    guessNumber = int.Parse(guess);

                    count += 1;

                    if (guessNumber > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else if (guessNumber < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                    else Console.WriteLine("You guessed it");
                    
                    Console.WriteLine();

                } while (magicNumber != guessNumber);

                Console.WriteLine($"You guessed {count} times!\n");

                Console.Write("Do you what to play again (Yes/No)? ");

                play = Console.ReadLine().ToLower();

            } while (play == "yes");

        }
    }
}
