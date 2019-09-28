using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleChess
{
    class Knight : ChessPiece
    {
        public Knight(bool IsWhite) : base(IsWhite)
        {
            Term = "K";
        }

        public override void CanMove(int xTo, int yTo)
        {
            throw new NotImplementedException();
        }
    }
}
