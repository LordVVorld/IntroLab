using ReactiveUI;
using DynamicData;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Reactive;
using System;
using static Q2.EditModel;
using static Q2.ReviewModel;

namespace IntroLab
{
    public class EditViewModel : ReactiveObject
    {
        private List<EditableGroup> _groupList = new List<EditableGroup>();
        public List<EditableGroup> GroupList
        {
            get => _groupList;
            set => this.RaiseAndSetIfChanged(ref _groupList, value);
        }

        private int _groupIndex;
        public int GroupIndex
        {
            get => _groupIndex;
            set => this.RaiseAndSetIfChanged(ref _groupIndex, value);
        }

        private string _groupName;
        public string GroupName
        {
            get => _groupName;
            set => this.RaiseAndSetIfChanged(ref _groupName, value);
        }

        private List<EditableStudent> _studentList;
        public List<EditableStudent> StudentList
        {
            get => _studentList;
            set => this.RaiseAndSetIfChanged(ref _studentList, value);
        }

        private int _studentIndex;
        public int StudentIndex
        {
            get => _studentIndex;
            set => this.RaiseAndSetIfChanged(ref _studentIndex, value);
        }

        private DataTable _studentData;
        public DataTable StudentData
        {
            get => _studentData;
            set => this.RaiseAndSetIfChanged(ref _studentData, value);
        }

        public EditViewModel(List<Group> groups)
        {
            foreach (var group in groups)
            {
                List<EditableStudent> students = new List<EditableStudent>();
                EditableStudent head = new EditableStudent();
                foreach (var student in group.Students)
                {
                    if (student.IsGroupHead)
                    {
                        head = new EditableStudent(student.Id,
                                                     student.Name,
                                                     student.SurName,
                                                     student.IsGroupHead,
                                                     student.GroupName);
                    }
                    students.Add(new EditableStudent(student.Id,
                                                     student.Name,
                                                     student.SurName,
                                                     student.IsGroupHead,
                                                     student.GroupName));
                }
                GroupList.Add(new EditableGroup(group.Name, students, head));
            };
            GroupName = GroupList[0].Name;
            StudentList = GroupList[0].Students;
            StudentData = StudentList[0].ToDataTable();
            GroupIndex = 0;
            StudentIndex = 0;

            SelectedGroupChanged = ReactiveCommand.Create<int>(index =>
            {
                GroupIndex = index;
                GroupName = GroupList[index].Name;
                StudentList = GroupList[index].Students;
            });

            SelectedStudentChanged = ReactiveCommand.Create<int>(index =>
            {
                StudentIndex = index;
                StudentData = GroupList[GroupIndex].Students[index].ToDataTable();
            });

            GroupNameChanged = ReactiveCommand.Create<string>(name =>
            {
                GroupList[GroupIndex].Name = name;
                GroupList[GroupIndex].Students.ForEach(student =>
                {
                    student.GroupName = name;
                });
            });
        }

        public ReactiveCommand<int, Unit> SelectedGroupChanged { get; private set; }
        public ReactiveCommand<int, Unit> SelectedStudentChanged { get; private set; }
        public ReactiveCommand<string, Unit> GroupNameChanged { get; private set; }
    }
}
