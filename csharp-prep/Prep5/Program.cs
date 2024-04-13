using System;
using System.Collections.Generic;



namespace Prep5
{
    class Program
    {
        static void DisplayWelcome()
        {
            Console.WriteLine($"Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string num = Console.ReadLine();
            int numInt = int.Parse(num);
            return numInt;
        }

        static int SquareNumber(int userNumber)
        {
            return userNumber * userNumber;
            
        }

        static void DisplayResult(string userName, int squaredNumber)
        {
            Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
        }

        static void Main(string[] args)
        {
            
            DisplayWelcome();
            string userName = PromptUserName();
            int userNumber = PromptUserNumber();
            int squaredNumber = SquareNumber(userNumber);
            DisplayResult(userName, squaredNumber);
        }
    }
    
}

