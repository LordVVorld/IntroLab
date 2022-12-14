using IntroLab;
using ReactiveUI;
using System.ComponentModel;
using System.Reactive.Linq;
using System.Windows.Forms;
using System;
using static Q2.ReviewModel;

namespace Q2
{
    public partial class ReviewView : Form, IViewFor<ReviewViewModel>
    {
        public ReviewView()
        {
            InitializeComponent();
            ViewModel = new ReviewViewModel();
            this.WhenActivated(a =>
            {
                a(this.Bind(ViewModel, vm => vm.GroupList, v => v.groupList.DataSource));
                a(this.Bind(ViewModel, vm => vm.ActiveGroup, v => v.groupList.SelectedItem));
                a(this.Bind(ViewModel, vm => vm.GroupName, v => v.groupNameBox.Text));
                a(this.Bind(ViewModel, vm => vm.StudentList, v => v.studentList.DataSource));
                a(this.Bind(ViewModel, vm => vm.ActiveStudent, v => v.studentList.SelectedItem));
                a(this.Bind(ViewModel, vm => vm.StudentData, v => v.studentDataGrid.DataSource));

                groupList.Events()
                         .SelectedValueChanged
                         .Select(args => groupList.SelectedItem as Group)
                         .InvokeCommand(ViewModel.SelectedGroupChanged);
                studentList.Events()
                         .SelectedValueChanged
                         .Select(_ => studentList.SelectedItem as Student)
                         .InvokeCommand(ViewModel.SelectedStudentChanged);
                editModButton.Events().Click.Subscribe(e =>
                { 
                    new EditView(ViewModel.GroupList) { Owner = this }.Show();
                    Hide();
                });
            });
        }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (ReviewViewModel)value;
        }

        public ReviewViewModel ViewModel { get; set; }
    }
}