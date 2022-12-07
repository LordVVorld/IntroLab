using System.Collections.Generic;

namespace Q2
{
    public static class Q2Model
    {
        public static Student student1 = new Student(1, "Александр", "Волков", false, 1);
        public static Student student2 = new Student(2, "Алексей", "Сугурдин", true, 1);
        public static Student student3 = new Student(3, "Елена", "Осаренко", false, 2);
        public static Student student4 = new Student(4, "Виталина", "Юрченко", true, 2);
        public static List<Student> students = new List<Student>() { student1, student2, student3, student4 };
        public static Group group1 = new Group("АР-191", new List<Student>() { student1, student2 }, student1);
        public static Group group2 = new Group("КП-201", new List<Student>() { student3, student4 }, student4);
        public static List<Group> groups = new List<Group>() { group1, group2 };

        public class Group
        {
            protected string _name;
            public string Name { get => _name; }

            protected List<Student> _students;
            public List<Student> Students { get => _students; }

            protected Student _head;
            public Student Head { get => _head; }

            public Group(string name, List<Student> students, Student head) : base()
            {
                _name = name;
                _students = students;
                _head = head;
            }
        }

        public class EditableGroup : Group
        {
            new public string Name
            {
                get => _name;
                set => _name = value;
            }

            new public List<Student> Students
            {
                get => _students;
                set => _students = value;
            }

            new public Student Head
            {
                get => _head;
                set => _head = value;
            }

            public EditableGroup(string name, List<Student> students, Student head) : base(name, students, head)
            {

            }
        }

        public class Student
        {
            protected int _id;
            public int Id { get => _id; }
            
            protected string _name;
            public string Name { get => _name; }
            
            protected string _surName;
            public string SurName { get => _surName; }
            
            protected bool _isGroupHead;
            public bool IsGroupHead { get => _isGroupHead; }
            
            public int GroupId { get => _groupId; }
            protected int _groupId;

            public Student(int id, string name, string surName, bool isGroupHead, int groupId)
            {
                _id = id;
                _name = name;
                _surName = surName;
                _isGroupHead = isGroupHead;
                _groupId = groupId;
            }
        }

        public class EditableStudent : Student
        {
            new public int Id
            {
                get => _id;
                set => _id = value;
            }

            new public string Name
            {
                get => _name;
                set => _name = value;
            }

            new public string SurName
            {
                get => _surName;
                set => _surName = value;
            }

            new public bool IsGroupHead
            {
                get => _isGroupHead;
                set => _isGroupHead = value;
            }

            new public int GroupId
            {
                get => _groupId;
                set => _groupId = value;
            }

            public EditableStudent(int id, string name, string surName, bool isGroupHead, int groupId)
                : base(id, name, surName, isGroupHead, groupId)
            {

            }
        }
    }
}
