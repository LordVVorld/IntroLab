using IntroLab;
using ReactiveUI;
using System.Windows.Forms;

namespace Q2
{
    public partial class Q2View : Form, IViewFor<Q2ViewModel>
    {
        public Q2View()
        {
            InitializeComponent();
            ViewModel = new Q2ViewModel();
            this.WhenActivated(a =>
            {

            });
        }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (Q2ViewModel)value;
        }

        public Q2ViewModel ViewModel { get; set; }
    }
}

