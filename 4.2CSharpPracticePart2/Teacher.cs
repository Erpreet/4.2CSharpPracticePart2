using System;
using System.Collections.Generic;
using System.Text;

namespace _4._2CSharpPracticePart2
{
    class Teacher : Person
    {
        public List<Student> Class { get; set; }

        public Classroom Room { get; set; }

        public void AssignHomework()
        {
            foreach (Student student in Class)
            {
                student.DoHomework();
            }
        }

        public Teacher(string firstName, string lastName, Classroom room)
        {
            FirstName = firstName;
            LastName = lastName;

            Class = new List<Student>();
            Room = room;
        }
    }
}
