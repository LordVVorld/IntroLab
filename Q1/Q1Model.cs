using Mommo.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Q1
{
    public class Q1Model
    {
        public class SquareMatrix
        {
            public int Rank { get; set; }
            public double[,] Values { get; set; }

            public SquareMatrix()
            {
                var randomizer = new Random();
                Rank = 5;
                Values = new double[Rank, Rank];
                for (int rowIndex = 0; rowIndex < Rank; rowIndex++)
                {
                    for (int columnIndex = 0; columnIndex < Rank; columnIndex++)
                    {
                        Values[rowIndex, columnIndex] = Math.Round(randomizer.NextDouble(), 3);
                    }
                }
            }

            public SquareMatrix(ArrayDataView matrix)
            {
                
                Rank = 5;
                ArrayList array = new ArrayList();
                for (int index = 0; index < matrix.Count; index++)
                {
                    array.Add(matrix[index]);
                }
                Array array1 = array.ToArray();
                Values = (double[,])array1;
                //for (int columnIndex = 0; columnIndex < Rank; columnIndex++)
                //{
                    //for (int rowIndex = 0; rowIndex < Rank; rowIndex++)
                    //{
                        //Values[rowIndex, columnIndex] = double.Parse(matrix[rowIndex, columnIndex].Value.ToString());
                    //}
                //}
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

        public static double GeometricMean(double firstNumber, double secondNumber) => Math.Sqrt(firstNumber * secondNumber);

        public static ArrayDataView MatrixToGrid(SquareMatrix matrix) => new ArrayDataView(matrix.Values);
    }
}
