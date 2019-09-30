using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleChess
{
    class King : ChessPiece
    {
        public King(bool isWhite) : base(isWhite)
        {
            Term = "K";
        }

        public override void CanMove(int xTo, int yTo)
        {
            throw new NotImplementedException();
        }
    }
}
