/*
* Name: [YOUR NAME HERE]
* South Hills Username: [YOUR SOUTH HILLS USERNAME HERE]
*/
using System;

namespace IT100_TicTacToe
{
    public class Program
    {
        //Define your 2D array here (I recommend either type char or string, but it is up to you).
        //Alternatively, you can make a Board class and define your 2D array there.

        public static void Main()
        {
            //Remove this call to GetInput() when you get started. It is here just to show you how the template code works.
            GetInput();
        }

        public static void GetInput()
        {
            PrintBoard();
            //Prompt the player.
            Console.Write("Player 1's turn (x's). Type in the row and column you want to place your x in, space-separated: ");
            //Take in a string as input, trim and split, then convert the string array to an int array.
            int[] coords = Array.ConvertAll(Console.ReadLine().Trim().Split(), Int32.Parse);

            //Check if the input is valid. If it is not, print an error message and get the input again.
            while (coords.Length != 2 || coords[0] < 1 || coords[0] > 3 || coords[1] < 1 || coords[1] > 3)
            {
                //Regenerate the board on the terminal/console to keep things clean.
                Console.Clear();
                PrintBoard();
                //Print an error.
                Console.Error.WriteLine("Invalid input. Please try again. Expecting 2 integers between 1-3, space-separated.");
                //Reprompt the player.
                Console.Write("Player 1's turn (x's). Type in the row and column you want to place your x in, space-separated: ");
                //Take in a string as input, trim and split, then convert the string array to an int array.
                coords = Array.ConvertAll(Console.ReadLine().Trim().Split(), Int32.Parse);
            }
            
            //Remove this line later. There should not be a print here. It has been provided to show you what the method did.
            Console.WriteLine($"Player typed in [{coords[0]}, {coords[1]}]");
        }

        public static void PrintBoard()
        {
            Console.Clear();
            //This is just an example of what a board should look like. Your board should be printed
            //  using the same format, but you should use a loop instead of writing it out like this.
            Console.WriteLine("\t x |   | o ");
            Console.WriteLine("\t---+---+---");
            Console.WriteLine("\t   | x | o ");
            Console.WriteLine("\t---+---+---");
            Console.WriteLine("\t   |   |   ");
            Console.WriteLine();
        }
    }
}