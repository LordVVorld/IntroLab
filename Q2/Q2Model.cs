using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Q2Model
    {
        public abstract class Group
        {
            private int _id;
            public int Id
            {
                get => _id;
                set => _id = value;
            }

            private Student[] _students;
        }

        public abstract class Student
        {
            private int _studentId;
            private string _name;
            private bool _isGroupHead;
            private Group _group;
        }

        public class EditableGroup : Group
        {

        }
    }
}
