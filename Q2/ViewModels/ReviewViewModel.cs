using ReactiveUI;
using DynamicData;
using System.Windows.Forms;
using static Q2.ReviewModel;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Reactive;
using System;
using Q2;

namespace IntroLab
{
    public class ReviewViewModel : ReactiveObject
    {
        private List<Group> _groupList;
        public List<Group> GroupList
        {
            get => _groupList;
            set => this.RaiseAndSetIfChanged(ref _groupList, value);
        }

        private Group _activeGroup;
        public Group ActiveGroup
        {
            get => _activeGroup;
            set => this.RaiseAndSetIfChanged(ref _activeGroup, value);
        }

        private string _groupName;
        public string GroupName
        {
            get => _groupName;
            set => this.RaiseAndSetIfChanged(ref _groupName, value);
        }

        private List<Student> _studentList;
        public List<Student> StudentList
        {
            get => _studentList;
            set => this.RaiseAndSetIfChanged(ref _studentList, value);
        }

        private Student _activeStudent;
        public Student ActiveStudent
        {
            get => _activeStudent;
            set => this.RaiseAndSetIfChanged(ref _activeStudent, value);
        }

        private DataTable _studentData;
        public DataTable StudentData
        {
            get => _studentData;
            set => this.RaiseAndSetIfChanged(ref _studentData, value);
        }

        public ReviewViewModel()
        {
            GroupList = InitGroupsData();
            GroupName = GroupList[0].Name;
            StudentList = GroupList[0].Students;
            StudentData = StudentList[0].ToDataTable();
            ActiveGroup = GroupList[0];
            ActiveStudent = GroupList[0].Students[0];

            SelectedGroupChanged = ReactiveCommand.Create<Group>(group =>
            {
                GroupName = group.Name;
                StudentList = group.Students;
            });

            SelectedStudentChanged = ReactiveCommand.Create<Student>(student => StudentData = student.ToDataTable());
        }

        public ReactiveCommand<Group, Unit> SelectedGroupChanged { get; private set; }
        public ReactiveCommand<Student, Unit> SelectedStudentChanged { get; private set; }
    }
}