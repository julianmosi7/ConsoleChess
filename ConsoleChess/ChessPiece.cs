using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleChess
{
    abstract class ChessPiece
    {
        public int X { get; set; }

        public int Y { get; set; }
        public string ShortName => $"{(IsWhite ? "w" : "s")}{Term}";
        public string Term { get; set; }
        public bool IsWhite { get; }

        public ChessPiece(bool IsWhite)
        {
            this.IsWhite = IsWhite;
        }

        public abstract void CanMove(int xTo, int yTo);  
    }
}
