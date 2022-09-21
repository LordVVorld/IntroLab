using System;
using System.Windows.Forms;

namespace Q1
{
    public class Q1Model
    {
        public class SquareMatrix
        {
            private int _rank;
            public int Rank
            {
                get => _rank;
                set => _rank = value;
            }

            private double[,] _values;
            public double[,] Values
            {
                get => _values;
                set => _values = value;
            }

            public SquareMatrix()
            {
                var randomizer = new Random();
                Rank = 5;
                Values = new double[Rank, Rank];
                for (int rowIndex = 0; rowIndex < Rank; rowIndex++)
                {
                    for (int columnIndex = 0; columnIndex < Rank; columnIndex++)
                    {
                        Values[rowIndex, columnIndex] = Math.Round(randomizer.NextDouble(), 2);
                    }
                }
            }

            public SquareMatrix(DataGridView matrix)
            {
                Rank = matrix.RowCount;
                for (int columnIndex = 0; columnIndex < matrix.ColumnCount; columnIndex++)
                {
                    for (int rowIndex = 0; rowIndex < matrix.RowCount; rowIndex++)
                    {
                        Values[rowIndex, columnIndex] = double.Parse(matrix[rowIndex, columnIndex].Value.ToString());
                    }
                }
            }

            public double MinLeftOfAuxDiagonal()
            {
                double minVal = Values[0, 0];
                int auxilaryColumn = 1;
                for (int rowIndex = 0; rowIndex < Rank; rowIndex++)
                {
                    int actualColumn = Rank - auxilaryColumn;
                    for (int columnIndex = actualColumn; columnIndex > 0; columnIndex--)
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
                int lastIndex = Rank - 1;
                double maxVal = Values[lastIndex, lastIndex];
                int auxilaryColumn = Rank - 1;
                for (int rowIndex = lastIndex; rowIndex > 0; rowIndex--)
                {
                    int actualColumn = auxilaryColumn + 1;
                    for (int columnIndex = actualColumn; columnIndex < Rank; columnIndex++)
                    {
                        if (Values[rowIndex, columnIndex] > maxVal)
                        {
                            maxVal = Values[rowIndex, columnIndex];
                        }
                    }
                    --auxilaryColumn;
                }
                return maxVal;
            }
        }
        
        public static double GeometricMean(double firstNumber, double secondNumber)
        {
            return Math.Sqrt(firstNumber * secondNumber);
        }

        public static DataGridView MatrixToGrid(SquareMatrix matrix)
        {
            DataGridView grid = new DataGridView();
            grid.RowCount = matrix.Rank;
            grid.ColumnCount = matrix.Rank;
            for (int columnIndex = 0; columnIndex < grid.ColumnCount; columnIndex++)
            {
                for (int rowIndex = 0; rowIndex < grid.RowCount; rowIndex++)
                {
                    grid[columnIndex, rowIndex].Value = matrix.Values[columnIndex, rowIndex];
                }
            }
            return grid;
        }
    }
}
