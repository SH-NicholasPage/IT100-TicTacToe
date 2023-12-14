/*
 * Name: [YOUR NAME HERE]
 * South Hills Username: [YOUR SOUTH HILLS USERNAME HERE]
 */

namespace TicTacToe
{
    public class Program
    {
        public const int BOARD_SIZE = 3;
        public static char[][] board = new char[BOARD_SIZE][];

        public static void Main()
        {
            //TODO
        }

        public static bool IsWinner(char[][] board)
        {
            // Check horizontals
            //TODO

            // Check verticals
            //TODO

            // Check diagonals
            bool diagonalWin = true;
            char mainDiagonalFirst = board[0][0];

            for (int i = 1; i < BOARD_SIZE; i++)
            {
                if (board[i][i] == ' ' || board[i][i] != mainDiagonalFirst)
                {
                    diagonalWin = false;
                    break;
                }
            }

            if (diagonalWin) return true;
            diagonalWin = true;

            char antiDiagonalFirst = board[0][BOARD_SIZE - 1];
            for (int i = BOARD_SIZE - 2; i >= 0; i--)
            {
                if (board[BOARD_SIZE - i - 1][i] == ' ' || board[BOARD_SIZE - i - 1][i] != antiDiagonalFirst)
                {
                    diagonalWin = false;
                    break;
                }
            }

            return diagonalWin;
        }

        public static void PrintBoard(char[][] board)
        {
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                Console.Write(" " + (i + 1));
            }

            Console.Write(Environment.NewLine);

            for (int i = 0; i < BOARD_SIZE; i++)
            {
                Console.WriteLine((i + 1) + String.Join('|', board[i]));

                if (i < BOARD_SIZE - 1)
                {
                    Console.WriteLine(" " + new String('-', BOARD_SIZE * 2 - 1));
                }
            }
        }
    }
}
