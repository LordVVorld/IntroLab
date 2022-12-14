using IntroLab;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reactive.Linq;
using System.Windows.Forms;
using static Q2.ReviewModel;

namespace Q2
{
    public partial class EditView : Form, IViewFor<EditViewModel>
    {
        public EditView(List<Group> groups)
        {
            InitializeComponent();
            ViewModel = new EditViewModel(groups);
            this.WhenActivated(a =>
            {
                a(this.Bind(ViewModel, vm => vm.GroupList, v => v.groupList.DataSource));
                a(this.Bind(ViewModel, vm => vm.GroupIndex, v => v.groupList.SelectedIndex));
                a(this.Bind(ViewModel, vm => vm.GroupName, v => v.groupNameBox.Text));
                a(this.Bind(ViewModel, vm => vm.StudentList, v => v.studentList.DataSource));
                a(this.Bind(ViewModel, vm => vm.StudentIndex, v => v.studentList.SelectedIndex));
                a(this.Bind(ViewModel, vm => vm.StudentData, v => v.studentDataGrid.DataSource));

                groupNameBox.Events()
                            .TextChanged
                            .Select(args => groupNameBox.Text)
                            .InvokeCommand(ViewModel.GroupNameChanged);

                groupList.Events()
                         .SelectedIndexChanged
                         .Select(args => groupList.SelectedIndex)
                         .InvokeCommand(ViewModel.SelectedGroupChanged);

                studentList.Events()
                         .SelectedIndexChanged
                         .Select(_ => studentList.SelectedIndex)
                         .InvokeCommand(ViewModel.SelectedStudentChanged);

                this.Events().Closed.Subscribe(e => Owner.Dispose());
            });
        }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (EditViewModel)value;
        }

        public EditViewModel ViewModel { get; set; }
    }
}