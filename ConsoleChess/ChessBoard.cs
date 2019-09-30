using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleChess
{
    class ChessBoard
    {
        static int fields;
        private List<ChessPiece> chessPiece = new List<ChessPiece>();
        //store all ChessPieces and show them
        public void Show()
        {
            ColorWriter blacktogrey = new ColorWriter() { ForeGroundColor = ConsoleColor.Black, BackGroundColor = ConsoleColor.Gray };
            Console.Write(" ");
            blacktogrey.WriteLine("-----------------------------------------");
            for (fields = 8; fields > 1; fields--)
            {
                Console.Write($"{fields}");
                blacktogrey.WriteLine("|    |    |    |    |    |    |    |    |");
                Console.Write(" ");
                blacktogrey.WriteLine("|----+----+----+----+----+----+----+----|");
            }
            Console.Write($"{fields}");
            blacktogrey.WriteLine("|    |    |    |    |    |    |    |    |");
            Console.Write(" ");
            blacktogrey.WriteLine("-----------------------------------------");
            Console.WriteLine("   a    b    c    d    e    f    g    h");
        }
    }
}
