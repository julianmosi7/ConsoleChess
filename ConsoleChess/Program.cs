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
                color = color.Equals("black") ? "black" : "white";
                move = ReadMove(round, color);
                color = ChangeColor(color);
                //first color
                //andere klasse sonst implementierung zweimal
                //mit liste vergleichen und schauen ob richtige color

                move = ReadMove(round, color);                
                color = ChangeColor(color);
                //second color
                //mit vorheriger class

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