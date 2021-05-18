using System;
using CalculatingLib;

namespace calculating_the_area
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("******Вычисление площади******");
            Console.WriteLine("-");
            Calculating Calc = new Calculating();

            double resultS = Calc.Calculate(10);
            string result = Calc.CheckTriangle(5, 12, 13);

            Console.WriteLine(resultS);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        

    }
}
