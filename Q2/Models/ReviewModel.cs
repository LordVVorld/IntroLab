using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Q2
{
    public static class ReviewModel
    {
        public class Group
        {
            protected string _name;
            public string Name { get => _name; }

            protected List<Student> _students;
            public List<Student> Students { get => _students; }

            protected Student _head;
            public Student Head { get => _head; }

            public Group(string name, List<Student> students, Student head)
            {
                _name = name;
                _students = students;
                _head = head;
            }
        }

        public class Student
        {
            protected string _id;
            public string Id { get => _id; }
            
            protected string _name;
            public string Name { get => _name; }
            
            protected string _surName;
            public string SurName { get => _surName; }
            
            protected bool _isGroupHead;
            public bool IsGroupHead { get => _isGroupHead; }

            protected string _groupName;
            public string GroupName { get => _groupName; }

            public Student(string id, string name, string surName, bool isGroupHead, string groupName)
            {
                _id = id;
                _name = name;
                _surName = surName;
                _isGroupHead = isGroupHead;
                _groupName = groupName;
            }
        }

        public static List<Group> InitGroupsData()
        {
            List<Student> studentList = new List<Student>()
            {
                new Student("Ф-200101", "Александр", "Волков", false, "АР-191"),
                new Student("Ф-200202", "Алексей", "Сугурдин", true, "АР-191"),
                new Student("Ф-200303", "Елена", "Осаренко", false, "ПС-171"),
                new Student("Ф-200404", "Виталина", "Юрченко", true, "ПС-171")
            };
            return new List<Group>()
            {
                new Group("АР-191",
                          studentList.FindAll(student => student.GroupName == "АР-191"),
                          studentList.Find(student => student.GroupName == "АР-191" && student.IsGroupHead)),
                new Group("ПС-171",
                          studentList.FindAll(student => student.GroupName == "ПС-171"),
                          studentList.Find(student => student.GroupName == "ПС-171" && student.IsGroupHead))
            };
        }

        public static DataTable ToDataTable(this Student student)
        {
            DataTable dt = new DataTable();
            dt.Rows.Add();
            dt.Columns.Add("ID");
            dt.Columns.Add("Имя");
            dt.Columns.Add("Фамилия");
            dt.Columns.Add("Староста");
            dt.Columns.Add("Группа");
            dt.Rows[0][0] = student.Id;
            dt.Rows[0][1] = student.Name;
            dt.Rows[0][2] = student.SurName;
            dt.Rows[0][3] = student.IsGroupHead ? "Да" : "Нет";
            dt.Rows[0][4] = student.GroupName;
            return dt;
        }
    }
}
