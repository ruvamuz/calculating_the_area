using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatingLib;

namespace UnitTests
{
    [TestClass]
    public class CalculatingTests
    {
        [TestMethod]
        public void SquareCircle_radius10()
        {
            //arrange
            double r = 10;
            double expected = 314.1592653589793;

            //act
            Calculating calc = new Calculating();
            double actual = calc.Calculate(r);

            //assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void SquareCircle_radiusLessZero()
        {
            //arrange
            double r = -10;
            double expected = 0;

            //act
            Calculating calc = new Calculating();
            double actual = calc.Calculate(r);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SquareTriangle_A3_B4_C5_6returned()
        {
            //arrange
            double A = 3;
            double B = 4;
            double C = 5;
            double expected = 6;

            //act
            Calculating calc = new Calculating();
            double actual = calc.Calculate(A,B,C);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SquareTriangle_A_B_C_LessZero()
        {
            //arrange
            double A = -5;
            double B = -4;
            double C = -1;
            double expected = 0;

            //act
            Calculating calc = new Calculating();
            double actual = calc.Calculate(A, B, C);

            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void CheckTriangle_A_B_C_LessZero()
        {
            //arrange
            double A = -5;
            double B = -4;
            double C = -1;
            string expected = "Не корректные данные";

            //act
            Calculating calc = new Calculating();
            string actual = calc.CheckTriangle(A, B, C);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckTriangle_A3_B4_C5()
        {
            //arrange
            double A = 3;
            double B = 4;
            double C = 5;
            string expected = "Прямоугольный треугольник";

            //act
            Calculating calc = new Calculating();
            string actual = calc.CheckTriangle(A, B, C);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckTriangle_A4_B4_C5()
        {
            //arrange
            double A = 4;
            double B = 4;
            double C = 5;
            string expected = "Не прямоугольный треугольник";

            //act
            Calculating calc = new Calculating();
            string actual = calc.CheckTriangle(A, B, C);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
