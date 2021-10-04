using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_10_5.Classes
{
    internal class Calculator : Logger, Interfaces.ICalculator
    {
        void Interfaces.ICalculator.Summation(int valueA, int ValueB)
        {
            if (valueA > 100 || ValueB > 100 || valueA < -100 || ValueB < -100)
            {
                throw new Exception("Значение value не может быть меньше чем -100 или больше чем 100.", new Exception("Ошибка!"));
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Результат : {0}", valueA + ValueB);
            }
        }
    }
}
