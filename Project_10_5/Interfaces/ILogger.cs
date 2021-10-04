using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_10_5.Interfaces
{
    internal interface ILogger
    {
        void Write(string Message);

        void Write(string Message, ConsoleColor BackgroundColor, ConsoleColor ForegroundColor);
    }
}
