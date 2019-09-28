using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleChess
{
    class ColorWriter
    {
        public ConsoleColor ForeGroundColor { get; set; }

        public ConsoleColor BackGroundColor { get; set; }

        public void WriteLine(string line)
        {
            Console.ForegroundColor = ForeGroundColor;
            Console.BackgroundColor = BackGroundColor;
            Console.WriteLine(line);
            Console.ResetColor();
        }

        public void Write(string line)
        {
            Console.ForegroundColor = ForeGroundColor;
            Console.BackgroundColor = BackGroundColor;
            Console.Write(line);
            Console.ResetColor();
        }
    }
}
