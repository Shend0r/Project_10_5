using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_10_5.Classes
{
    internal class Logger : Interfaces.ILogger
    {
        void Interfaces.ILogger.Write(string Message)
        {
            Console.WriteLine(Message);
        }

        void Interfaces.ILogger.Write(string Message, ConsoleColor BackgroundColor, ConsoleColor ForegroundColor)
        {
            Console.BackgroundColor = BackgroundColor;
            Console.ForegroundColor = ForegroundColor;
            Console.WriteLine(Message);
        }
    }
}
