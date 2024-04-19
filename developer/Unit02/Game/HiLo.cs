using System;

namespace Unit02.Game
{
    // The HiLo Class contains the logic of the HiLo game.
    public class HiLo
    {
        public int score;
        public int value;
        public string play = "y";

        // The constructor of the HiLo class
        public HiLo()
        {
            score = 300;
            Card();
        }

        // The Card method generates a random number between 1 and 13
        public void Card()
        {
            Random random = new Random();
            value = random.Next(1, 13);
        }

        // The TakeInput method takes input from the player
        public string TakeInput()
        {
            Console.Write("Higher or lower? [h/l] ");
            string guess = Console.ReadLine();
            return guess;
        }

        // The ValidateInput methods checks if the input is valid
        public bool ValidateInput(string guess)
        {
            if (guess == "l" || guess == "h") return true;
            return false;
        }

        // The UpdateScore method update the score based on the player's input 
        public void UpdateScore(string guess)
        {
            int currentScore = value;
            Card();
            int nextScore = value;

            if (guess == "l" && nextScore < currentScore) score += 100;
            else if (guess == "h" && nextScore > currentScore) score += 100;
            else score -= 75;

        }

        // The Play method contains the logic of repeatedly playing the game 
        public void Play()
        {
            while (play == "y")
            {
                Console.WriteLine($"The card is {value}");

                string guess;
                
                while (true)
                {
                    guess = TakeInput();
                    bool validate = ValidateInput(guess);

                    if (validate) break;

                } 

                UpdateScore(guess);

                Console.WriteLine($"The next card is: {value}");
                Console.WriteLine($"Your score is: {score}");

                if (score > 0) 
                {
                    Console.Write("Play again? [y/n] ");
                    play = Console.ReadLine(); 
                }
                else play = "n";

                Console.WriteLine();
                
            }

            if (score <= 0) Console.WriteLine("Game Over!");
            else Console.WriteLine("Thanks for playing!");     
        }
    }
}