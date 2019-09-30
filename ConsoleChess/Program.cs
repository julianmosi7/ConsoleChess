using System;

namespace ConsoleChess
{
    class Program
    {
        static void Main(string[] args)
        {
            string move;
            bool player_won = false;
            string color = "black";
            ChessBoard chessBoard = new ChessBoard();
            chessBoard.Show();
            for (int round = 0; player_won == false; round++)
            {
                //1. Zug weiß, 2. Zug black, 3. Zug weiß -> false  f|r  1. Zug weiß, 1. Zug black, 2. Zug weiß, ...
                //if verzweigung als einzeiler mit ? und :
                color = color.Equals("black") ? "black" : "white";
                move = ReadMove(round, color);
            }
        }

        private static string ReadMove(int round, string color)
        {
            string move;
            Console.WriteLine($"{round}. Zug {color}:");
            move = Console.ReadLine();
            return move;
        }
    }
}