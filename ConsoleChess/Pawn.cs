using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleChess
{
    class Pawn:ChessPiece
    {
        public Pawn(bool IsWhite) : base(IsWhite)
        {
            Term = "P";
        }

        public override void CanMove(int xTo, int yTo)
        {
            throw new NotImplementedException();
        }
    }
}
