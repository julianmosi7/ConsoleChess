using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleChess
{
    class ChessBoard
    {
        static int fields;
        private List<ChessPiece> chessPieces = new List<ChessPiece>
        {
            //black
            new Rook(false){X = "a", Y = 8},
            new Rook(false){X = "h", Y = 8},

            new Knight(false){X = "b", Y = 8},
            new Knight(false){X = "g", Y = 8},

            new Bishop(false){X = "c", Y = 8},
            new Bishop(false){X = "f", Y = 8},

            new Queen(false){X = "d", Y = 8},

            new King(false){X = "e", Y = 8},

            new Pawn(false){X = "a", Y = 7},
            new Pawn(false){X = "b", Y = 7},
            new Pawn(false){X = "c", Y = 7},
            new Pawn(false){X = "d", Y = 7},
            new Pawn(false){X = "e", Y = 7},
            new Pawn(false){X = "f", Y = 7},
            new Pawn(false){X = "g", Y = 7},
            new Pawn(false){X = "h", Y = 7},

            //white
            new Rook(true){X = "a", Y = 1},
            new Rook(true){X = "h", Y = 1},

            new Knight(true){X = "b", Y = 1},
            new Knight(true){X = "g", Y = 1},

            new Bishop(true){X = "c", Y = 1},
            new Bishop(true){X = "f", Y = 1},

            new Queen(true){X = "d", Y = 1},            

            new King(true){X = "e", Y = 1},           
           
            new Pawn(true){X = "a", Y = 2},
            new Pawn(true){X = "b", Y = 2},
            new Pawn(true){X = "c", Y = 2},
            new Pawn(true){X = "d", Y = 2},
            new Pawn(true){X = "e", Y = 2},
            new Pawn(true){X = "f", Y = 2},
            new Pawn(true){X = "g", Y = 2},
            new Pawn(true){X = "h", Y = 2}
            
        };        
        
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
            ShowPieces();
            //in dieser klasse methode mit, zielfeld leer oder nicht, auf Startfeld Figur, ...
        }

        public void ShowPieces()
        {
            int left;
            int top;
            left = Console.CursorLeft;
            top = Console.CursorTop;
            //3, 8, 13 -> +5
            //13, 15
            int position_left = 3;
            int position_top = 1;
            foreach (var chessPiece in chessPieces)
            {
                for (int i = 0; i < 2; i++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            Console.SetCursorPosition(position_left, position_top);
                            //if ob weiß oder black und dann entsprechende color setzen
                            Console.Write(chessPiece.ShortName);
                            position_left += 5;
                        }
                        position_top += 2;
                        position_left = 3;
                    }
                    position_top = 13;
                }
            }
                    
            Console.SetCursorPosition(left, top);
        }
    }
}
