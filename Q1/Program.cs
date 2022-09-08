using System;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }

    class Matrix
    {
        int Rank { get; set; }
        double[,] Values { get; set; }
        
        public Matrix()
        {
            var randomizer = new Random();
            Rank = 5;
            for (int rowIndex = 0; rowIndex < Rank; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < Rank; columnIndex++)
                {
                    Values[rowIndex, columnIndex] = Math.Round(randomizer.NextDouble(), 2);
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
            double maxVal = Values[Rank, Rank];
            int auxilaryColumn = 1;
            for (int rowIndex = Rank; rowIndex > 0; rowIndex--)
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
