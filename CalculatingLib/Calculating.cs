using System;

namespace CalculatingLib
{
    public class Calculating
    {
        /// <summary>
        /// Метод вычисления площади круга по радиусу
        /// </summary>
        /// <param name="radiusCircle">Значение радиуса</param>
        /// <returns>Площадь круга</returns>
        public double Calculate(double radiusCircle)
        {
            if (radiusCircle > 0 )
            {
                double S = Math.PI * Math.Pow(radiusCircle, 2);
                return S;
            } 
            else
            {
                return 0;
            }
            
        }

        /// <summary>
        /// Метод вычисления Треугольника
        /// </summary>
        /// <param name="A">Сторона треугольника А, катет</param>
        /// <param name="B">Сторона треугольника B, катет</param>
        /// <param name="C">Сторона треугольника C, гипотенуза</param>
        /// <returns></returns>
        public double Calculate(double A, double B, double C)
        {
            if ((A > 0) & (B > 0) & (C > 0))
            {
                double p = (A + B + C) / 2;
                double S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
                return S;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Метод проверки треугольника. Является ли треугольник прямоугольным?
        /// </summary>
        /// <param name="A">Сторона треугольника А, катет</param>
        /// <param name="B">Сторона треугольника B, катет</param>
        /// <param name="C">Сторона треугольника C, гипотенуза</param>
        /// <returns></returns>
        public string CheckTriangle(double A, double B, double C)
        {
            if ((A > 0) & (B > 0) & (C > 0))
            {
                string result = (Math.Pow(C, 2) == Math.Pow(A, 2) + Math.Pow(B, 2)) ? "Прямоугольный треугольник" : "Не прямоугольный треугольник";
                return result;
            }
            else
            {
                return "Не корректные данные";
            }
        }
    }
}
