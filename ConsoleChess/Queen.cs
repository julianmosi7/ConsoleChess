using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleChess
{
    class Queen : ChessPiece
    {
        public Queen(bool IsWhite) : base(IsWhite)
        {
            Term = "D"; 
        }

        public override void CanMove(int xTo, int yTo)
        {
            throw new NotImplementedException();
        }
    }
}
