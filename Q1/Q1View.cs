using ReactiveUI;
using System.Windows.Forms;

namespace Q1
{
    public partial class Q1View : Form, IViewFor<Q1ViewModel>
    {
        public Q1View()
        {
            InitializeComponent();
            this.WhenActivated(action =>
            {
                action(this.Bind(ViewModel, vm => vm.ManualInputed, v => v.manualInputButton.Checked));
                action(this.Bind(ViewModel, vm => vm.Matrix, v => v.matrixGrid.DataSource));
                action(this.OneWayBind(ViewModel, vm => vm.MinLeft, v => v.minLeftBox.Text));
                action(this.OneWayBind(ViewModel, vm => vm.MaxRight, v => v.maxRightBox.Text));
                action(this.OneWayBind(ViewModel, vm => vm.GeometricMean, v => v.geometricMeanBox.Text));
                action(this.BindCommand(ViewModel, vm => vm.Start, v => v.startButton));
            });
            ViewModel = new Q1ViewModel();
        }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (Q1ViewModel)value;
        }

        public Q1ViewModel ViewModel { get; set; }

        private void ColumnAdded(object sender, DataGridViewColumnEventArgs e) => ((DataGridViewTextBoxColumn)e.Column).MaxInputLength = 10;
    }
}
