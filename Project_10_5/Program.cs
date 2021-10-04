using System;

namespace Project_10_5
{
    class Program
    {
        public static Classes.Calculator calculator;

        static void Main(string[] args)
        {
            calculator = new Classes.Calculator();

            try
            {
                ((Interfaces.ICalculator)calculator).Summation(101, 5);
            }
            catch
            {
                ((Interfaces.ILogger)calculator).Write("Ошибка! Значение value не может быть меньше чем -100 или больше чем 100.", ConsoleColor.Red, ConsoleColor.Black);
            }

            Console.ReadKey();
        }
    }
}
