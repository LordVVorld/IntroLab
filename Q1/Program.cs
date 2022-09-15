using System;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            SquareMatrix matrix = new SquareMatrix();
            Console.WriteLine("Сгенерированная матрица: ");
            matrix.Print();
            double minLeft = matrix.MinLeftOfAuxDiagonal();
            double maxRight = matrix.MaxRightOfAuxDiagonal();
            Console.WriteLine("Наименьшее значение слева от побочной диагонали: {0}", minLeft);
            Console.WriteLine("Наибольшее значение справа от побочной диагонали: {0}", maxRight);
            Console.WriteLine("Среднее геометрическое этих значений: {0}", GeometricMean(minLeft, maxRight));
        }

        public static double GeometricMean(double firstNumber, double secondNumber) => Math.Sqrt(firstNumber * secondNumber);
    }
}
