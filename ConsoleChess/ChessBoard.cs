using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleChess
{
    class ChessBoard
    {
        public void Show()
        {
            ColorWriter greytogrey = new ColorWriter() { ForeGroundColor = ConsoleColor.Black, BackGroundColor = ConsoleColor.Gray };
            greytogrey.Write("--------------------------------");
        }
    }
}
