using ReactiveUI;
using System;
using System.Data;
using System.Reactive;
using System.Windows.Forms;

namespace Q1
{
    public class Q1ViewModel : ReactiveObject 
    {
        private bool _manualInputed;
        public bool ManualInputed
        {
            get => _manualInputed;
            set => this.RaiseAndSetIfChanged(ref _manualInputed, value);
        }

        private int _matrixRank;
        public int MatrixRank
        {
            get => _matrixRank;
            set => this.RaiseAndSetIfChanged(ref _matrixRank, value);
        }

        private double _minLeft;
        public double MinLeft
        {
            get => _minLeft;
            set => this.RaiseAndSetIfChanged(ref _minLeft, value);
        }

        private double _maxRight;
        public double MaxRight
        {
            get => _maxRight;
            set => this.RaiseAndSetIfChanged(ref _maxRight, value);
        }

        private double _geometricMean;
        public double GeometricMean
        {
            get => _geometricMean;
            set => this.RaiseAndSetIfChanged(ref _geometricMean, value);
        }

        private DataTable _matrix = Q1Model.CreateUIInputTable();
        public DataTable Matrix
        {
            get => _matrix;
            set => this.RaiseAndSetIfChanged(ref _matrix, value);
        }

        public Q1ViewModel()
		{
            Start = ReactiveCommand.Create(() =>
            {
                try
                {
                    var matrix = ManualInputed ? new Q1Model.SquareMatrix(Matrix) : new Q1Model.SquareMatrix();
                    Matrix = Q1Model.MatrixValuesToDataTable(matrix);
                    MinLeft = matrix.MinLeftOfAuxDiagonal();
                    MaxRight = matrix.MaxRightOfAuxDiagonal();
                    GeometricMean = Q1Model.GeometricMean(MaxRight, MinLeft);
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message, "Ошибка.");
                }
            });
        }

        public ReactiveCommand<Unit, Unit> Start { get; private set; }
    }
}
