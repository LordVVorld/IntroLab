using System;
using System.Data;

namespace Q1
{
    public class Q1Model
    {
        public class SquareMatrix
        {
            public readonly int rank = 5;
            public double[,] Values { get; set; }

            public SquareMatrix(DataTable matrix = null)
            {
                if (!(matrix is null))
                {
                    Values = DataTableToMatrixValues(matrix);
                    return;
                }
                var randomizer = new Random();
                Values = new double[rank, rank];
                for (int rowIndex = 0; rowIndex < rank; ++rowIndex)
                {
                    for (int columnIndex = 0; columnIndex < rank; ++columnIndex)
                    {
                        Values[rowIndex, columnIndex] = Math.Round(randomizer.NextDouble(), 3);
                    }
                }
            }

            public double MinLeftOfAuxDiagonal()
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

            public double MaxRightOfAuxDiagonal()
            {
                int lastIndex = rank - 1;
                double maxVal = Values[lastIndex, lastIndex];
                int auxilaryColumn = 0; //0
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

        public static double GeometricMean(double firstNumber, double secondNumber) => Math.Round(Math.Sqrt(firstNumber * secondNumber), 5);

        private static double[,] DataTableToMatrixValues(DataTable table)
        {
            double[,] matrix = new double[5,5];
            for (int rowIndex = 0; rowIndex < table.Rows.Count; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < table.Columns.Count; columnIndex++)
                {
                    try
                    {
                        matrix[rowIndex, columnIndex] = double.Parse(table.Rows[rowIndex][columnIndex].ToString());
                    }
                    catch
                    {
                        throw new ArgumentException(string.Format("Некорректное значение в ячейке [{0},{1}]", rowIndex + 1, columnIndex + 1));
                    }
                }
            }
            return matrix;
        }

        public static DataTable MatrixValuesToDataTable(SquareMatrix matrix)
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

        public static DataTable CreateUIInputTable(DataTable table = null)
        {
            if (table is null)
            {
                table = new DataTable();
                for (int rowIndex = 0; rowIndex < 5; rowIndex++)
                {
                    table.Rows.Add();
                    table.Columns.Add();
                }
            }
            for (int rowIndex = 0; rowIndex < 5; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < 5; columnIndex++)
                {
                    if (table.Rows[rowIndex][columnIndex] is null)
                    {
                        table.Rows[rowIndex][columnIndex] = "";
                    }
                }
            }
            return table;
        }
    }
}
