using System;
using System.Data;
using static Q1.Q1Model;

namespace Q1
{
    public class Q1Model
    {
        public class SquareMatrix
        {
            public readonly int rank = 5;
            public double[,] Values { get; set; }

            public SquareMatrix()
            {

            }

            public SquareMatrix(Random randomizer)
            {
                Values = new double[rank, rank];
                for (int rowIndex = 0; rowIndex < rank; ++rowIndex)
                {
                    for (int columnIndex = 0; columnIndex < rank; ++columnIndex)
                    {
                        Values[rowIndex, columnIndex] = Math.Round(randomizer.NextDouble(), 3);
                    }
                }
            }

            public double MinLeftOfAuxDiag()
            {
                double minVal = Values[0, 0];
                int auxilaryColumn = 1;
                for (int rowIndex = 0; rowIndex < rank; rowIndex++)
                {
                    int actualColumn = rank - auxilaryColumn - 1;
                    for (int columnIndex = actualColumn; columnIndex >= 0; columnIndex--)
                    {
                        if (Values[rowIndex, columnIndex] < minVal)
                        {
                            minVal = Values[rowIndex, columnIndex];
                        }
                    }
                    ++auxilaryColumn;
                }
                return minVal;
            }

            public double MaxRightOfAuxDiag()
            {
                int lastIndex = rank - 1;
                double maxVal = Values[lastIndex, lastIndex];
                int auxilaryColumn = 0;
                for (int rowIndex = lastIndex; rowIndex > 0; --rowIndex)
                {
                    int actualColumn = auxilaryColumn + 1;
                    for (int columnIndex = actualColumn; columnIndex < rank; ++columnIndex)
                    {
                        if (Values[rowIndex, columnIndex] > maxVal)
                        {
                            maxVal = Values[rowIndex, columnIndex];
                        }
                    }
                    ++auxilaryColumn;
                }
                return maxVal;
            }
        }

        public static double GeometricMean(double firstNumber, double secondNumber) => Math.Sqrt(firstNumber * secondNumber);
    }

    public static class ExtentionMethods
    {
        public static SquareMatrix ConvertToMatrix(this DataTable table)
        {
            SquareMatrix matrix = new SquareMatrix { Values = new double[table.Rows.Count, table.Columns.Count] };
            for (int rowIndex = 0; rowIndex < table.Rows.Count; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < table.Columns.Count; columnIndex++)
                {
                    string value = table.Rows[rowIndex][columnIndex].ToString();
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new Exception($"Пустое значение в ячейке [{rowIndex + 1},{columnIndex + 1}]");
                    }
                    if (!double.TryParse(value, out matrix.Values[rowIndex, columnIndex]))
                    {
                        throw new Exception($"Некорректное значение в ячейке [{rowIndex + 1},{columnIndex + 1}]");
                    }
                }
            }
            return matrix;
        }

        public static DataTable ConvertToDataTable(this SquareMatrix matrix)
        {
            DataTable table = new DataTable();
            for (int rowIndex = 0; rowIndex < matrix.rank; rowIndex++)
            {
                table.Rows.Add();
                table.Columns.Add();
            }
            for (int rowIndex = 0; rowIndex < matrix.rank; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < matrix.rank; columnIndex++)
                {
                    table.Rows[rowIndex][columnIndex] = matrix.Values[rowIndex, columnIndex];
                }
            }
            return table;
        }

        public static DataTable InitUIDataTable(this DataTable table)
        {
            for (int rowIndex = 0; rowIndex < 5; rowIndex++)
            {
                table.Rows.Add();
                table.Columns.Add();
            }
            for (int rowIndex = 0; rowIndex < 5; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < 5; columnIndex++)
                {
                    table.Rows[rowIndex][columnIndex] = "";
                }
            }
            return table;
        }
    }
}