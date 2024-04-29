using System;
using System.Linq;
namespace FunnyMath
    ;
class Program
{
    static void Main(string[] args)
    {
        Game game = new Game();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("\t\tWELCOME TO MY FUNNY MATH GAME!\n\n");
        Console.ResetColor();
        bool gameContinue = true;

        while (gameContinue)
        {

            Console.ResetColor();
            Console.WriteLine("\tWould you like to run the game?\n\tYES-1, NO-2");
            string answer = Console.ReadLine();

            if (answer == "1")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                game.RandomNumberGenerator();
                game.RunningGame();
            }
            else
            {
                Console.BackgroundColor.CompareTo(Console.ForegroundColor = ConsoleColor.DarkYellow);
                Console.WriteLine("\tTHANK YOU AND I HOPE SEE YOU SOON!");
                Console.ResetColor();
                Console.ReadKey();
                break;

            }

        }
        //Console.WriteLine("\tWould you like to run game again? \n\tYES-1, NO-2");
        //answer = Console.ReadLine();


    }
}
