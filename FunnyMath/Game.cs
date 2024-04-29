
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnyMath
{
    public class Game
    {
        int attempts = 0;
        int[] correctNumber = new int[4];
        public void RandomNumberGenerator()
        {
            // Generate a random 4-digit number made up of unique digits

            Random rand = new Random();
            for (int i = 0; i < 4; i++)
            {
                correctNumber[i] = rand.Next(0, 9);
                var number = correctNumber[i];

                for (int j = 0; j < i; j++)
                {
                    if (correctNumber[i] == correctNumber[j])
                    {
                        i--;

                        break;
                    }
                }

            }
        }
        public void RunningGame()
        {
            while (true)
            {
                // Get the user's guess
                Console.Write("Enter a 4-digit number made up of unique digits: ");
                int[] guess = Console.ReadLine().Select(x => x - '0').ToArray();
                attempts++;

                // Check if the guess is correct
                if (guess.SequenceEqual(correctNumber))
                {
                    Console.WriteLine("Congratulations, you guessed the number in " + attempts + " attempts!");
                    break;
                }

                // Check how many digits are in the correct position
                int correctPositions = 0;
                for (int i = 0; i < 4; i++)
                {
                    if (guess[i] == correctNumber[i])
                    {
                        correctPositions++;
                    }
                }
                Console.WriteLine(correctPositions + " digits in correct position.");

                // Check how many digits are in the incorrect position
                int correctDigits = 0;
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (guess[i] == correctNumber[j] && i != j)
                        {
                            correctDigits++;
                        }
                    }
                }
                Console.WriteLine(correctDigits + " digits in incorrect position.");
            }
        }
    }
}