using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleChess
{
    class Bishop : ChessPiece
    {
        public Bishop(bool IsWhite) : base(IsWhite)
        {
            Term = "B";
        }
        public override void CanMove(int xTo, int yTo)
        {
            throw new NotImplementedException();
        }
    } 
   
}
