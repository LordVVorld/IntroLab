using ReactiveUI;
using System;
using System.Data;
using System.Reactive;
using System.Windows.Forms;
using static Q1.Q1Model;

namespace Q1
{
    public class Q1ViewModel : ReactiveObject 
    {
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

        private DataTable _matrixDataTable = new DataTable().InitUIDataTable();
        public DataTable MatrixDataTable
        {
            get => _matrixDataTable;
            set => this.RaiseAndSetIfChanged(ref _matrixDataTable, value);
        }

        public Q1ViewModel()
		{
            AutofillMatrix = ReactiveCommand.Create(() => MatrixDataTable = new SquareMatrix(new Random()).ConvertToDataTable());
            AutofillMatrix.ThrownExceptions.Subscribe(error => MessageBox.Show(error.Message, "Внимание!"));

            EvaluateValues = ReactiveCommand.Create(() =>
            {
                MinLeft = MatrixDataTable.ConvertToMatrix().MinLeftOfAuxDiag();
                MaxRight = MatrixDataTable.ConvertToMatrix().MaxRightOfAuxDiag();
                GeometricMean = Math.Round(GeometricMean(MaxRight, MinLeft), 5);
            });
            EvaluateValues.ThrownExceptions.Subscribe(error => MessageBox.Show(error.Message, "Внимание!"));
        }

        public ReactiveCommand<Unit, DataTable> AutofillMatrix { get; private set; }
        public ReactiveCommand<Unit, Unit> EvaluateValues { get; private set; }
    }
}
