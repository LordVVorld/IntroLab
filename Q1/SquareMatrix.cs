using System;
using System.Collections.Generic;
using System.Text;

namespace Q1
{
    internal class SquareMatrix
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
                    Values[rowIndex, columnIndex] = Math.Round(randomizer.NextDouble(), 2);
                }
            }
        }

        public void Print()
        {
            for (int rowIndex = 0; rowIndex < Rank; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < Rank; columnIndex++)
                {
                    Console.Write(Values[rowIndex, columnIndex] + "  ");
                }
                Console.WriteLine();
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

        public double GeometricMeanLeftOfAuxDiagonal()
        {
            double geometricMean = 0;
            int auxilaryColumn = 1;
            int numberCount = 0;
            for (int rowIndex = 0; rowIndex < Rank; rowIndex++)
            {
                int actualColumn = Rank - auxilaryColumn;
                for (int columnIndex = actualColumn; columnIndex > 0; columnIndex--)
                {
                    ++numberCount;
                    geometricMean += Math.Log(Values[rowIndex, columnIndex]);
                }
                ++auxilaryColumn;
            }
            geometricMean = Math.Pow(10, geometricMean / numberCount);
            return geometricMean;
        }

        public double GeometricMeanRightOfAuxDiagonal()
        {
            double geometricMean = 0;
            int numberCount = 0;
            int auxilaryColumn = 1;
            for (int rowIndex = Rank; rowIndex > 0; rowIndex--)
            {
                int actualColumn = Rank - auxilaryColumn;
                for (int columnIndex = actualColumn; columnIndex > 0; columnIndex--)
                {
                    ++numberCount;
                    geometricMean += Math.Log(Values[rowIndex, columnIndex]);
                }
                --auxilaryColumn;
            }
            geometricMean = Math.Pow(10, geometricMean / numberCount);
            return geometricMean;
        }
    }
}
