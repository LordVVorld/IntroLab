using System.Collections.Generic;
using static Q2.ReviewModel;

namespace Q2
{
    public static class EditModel
    {
        public class EditableGroup : Group
        {
            new public string Name
            {
                get => _name;
                set => _name = value;
            }

            new private List<EditableStudent> _students;
            new public List<EditableStudent> Students
            {
                get => _students;
                set => _students = value;
            }

            new private EditableStudent _head;
            new public EditableStudent Head
            {
                get => _head;
                set => _head = value;
            }

            public EditableGroup() : base(null, null, null)
            {

            }

            public EditableGroup(string name, List<EditableStudent> students, EditableStudent head) : base(name, null, null)
            {
                _students = students;
                _head = head;
            }
        }

        public class EditableStudent : Student
        {
            new public string Id
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

            new public string GroupName
            {
                get => _groupName;
                set => _groupName = value;
            }

            public EditableStudent() : base(null, null, null, false, null)
            {

            }

            public EditableStudent(string id, string name, string surName, bool isGroupHead, string groupName)
                : base(id, name, surName, isGroupHead, groupName)
            {

            }
        }
    }
}
