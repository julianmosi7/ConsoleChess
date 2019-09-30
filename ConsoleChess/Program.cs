using System;

namespace ConsoleChess
{
    class Program
    {
        static void Main(string[] args)
        {
            string move;
            bool player_won = false;
            string color = "white";
            ChessBoard chessBoard = new ChessBoard();
            chessBoard.Show();
            for (int round = 1; player_won == false; round++)
            {
                //1. Zug weiß, 2. Zug black, 3. Zug weiß -> false  f|r  1. Zug weiß, 1. Zug black, 2. Zug weiß, ...                
                color = color.Equals("black") ? "black" : "white";
                move = ReadMove(round, color);
                color = ChangeColor(color);
                move = ReadMove(round, color);                
                color = ChangeColor(color);
            }
        }

        private static string ReadMove(int round, string color)
        {
            string move;
            Console.WriteLine($"{round}. Zug {color}:");
            move = Console.ReadLine();         
            return move;
        }    
        
        private static string ChangeColor(string color)
        {
            color = color.Equals("black") ? "white" : "black";
            return color;
        }
    }
}