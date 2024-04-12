using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Prep2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to your grade checker.\nEnter your score: ");
            string score = Console.ReadLine();
            int scoreInt = int.Parse(score);

            string letterGrade;
        
            if (scoreInt >= 90) letterGrade = "A";
            else if (scoreInt >= 80) letterGrade = "B";
            else if (scoreInt >= 70) letterGrade = "C";
            else if (scoreInt >= 60) letterGrade = "D";
            else letterGrade = "F";

            string gradeSign;

            int denomScore = scoreInt % 10;

            if (letterGrade == "F" || (letterGrade == "A" && denomScore >= 7)) gradeSign = "";
            else if (denomScore >= 7 && letterGrade != "A") gradeSign = "+";
            else if (denomScore < 3) gradeSign = "-";
            else gradeSign = "";


            Console.WriteLine($"Your letter Grade is {letterGrade}{gradeSign}");
            if (scoreInt >= 70) Console.WriteLine("Congratulations, you passed!");
            else Console.WriteLine("Unfortunately, you did not pass. Try again next time!");


        }
    }
}
