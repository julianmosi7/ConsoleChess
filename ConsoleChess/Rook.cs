using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleChess
{
    class Rook : ChessPiece
    {
        public Rook(bool IsWhite) : base(IsWhite)
        {
            Term = "R";
        }

        public override void CanMove(int xTo, int yTo)
        {
            throw new NotImplementedException();
        }
    }
}
