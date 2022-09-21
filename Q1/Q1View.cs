using ReactiveUI;
using System.Windows.Forms;

namespace Q1
{
    public partial class Q1View : Form, IViewFor<Q1ViewModel>
    {
        public Q1View()
        {
            InitializeComponent();
            matrixGrid.Rows.Add(5);
            

            this.WhenActivated(a =>
            {
                a(this.Bind(ViewModel, vm => vm.ManualInputed, v => v.manualInputButton.Checked));
                a(this.Bind(ViewModel, vm => vm.Matrix, v => v.matrixGrid));
                a(this.OneWayBind(ViewModel, vm => vm.MinLeft, v => v.minLeftBox.Text));
                a(this.OneWayBind(ViewModel, vm => vm.MaxRight, v => v.maxRightBox.Text));
                a(this.OneWayBind(ViewModel, vm => vm.GeometricMean, v => v.geometricMeanBox.Text));
                a(this.BindCommand(ViewModel, vm => vm.Start, v => v.startButton));
            });
            ViewModel = new Q1ViewModel();
        }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (Q1ViewModel)value;
        }

        public Q1ViewModel ViewModel { get; set; }
    }
}
