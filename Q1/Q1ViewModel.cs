using ReactiveUI;
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

        private string _minLeft;
        public string MinLeft
        {
            get => _minLeft;
            set => this.RaiseAndSetIfChanged(ref _minLeft, value);
        }

        private string _maxRight;
        public string MaxRight
        {
            get => _maxRight;
            set => this.RaiseAndSetIfChanged(ref _maxRight, value);
        }

        private string _geometricMean;
        public string GeometricMean
        {
            get => _geometricMean;
            set => this.RaiseAndSetIfChanged(ref _geometricMean, value);
        }

        private DataGridView _matrix;
        public DataGridView Matrix
        {
            get => _matrix;
            set => this.RaiseAndSetIfChanged(ref _matrix, value);
        }

        public Q1ViewModel()
		{
            Start = ReactiveCommand.Create(()=>
            {
                var matrix = ManualInputed? new Q1Model.SquareMatrix(Matrix) : new Q1Model.SquareMatrix();
                Matrix = Q1Model.MatrixToGrid(matrix);
                MinLeft = matrix.MinLeftOfAuxDiagonal().ToString();
                MaxRight = matrix.MaxRightOfAuxDiagonal().ToString();
                GeometricMean = Q1Model.GeometricMean(double.Parse(MaxRight), double.Parse(MinLeft)).ToString("0.000");
            });
        }

        public ReactiveCommand<Unit, Unit> Start { get; private set; }
    }
}
