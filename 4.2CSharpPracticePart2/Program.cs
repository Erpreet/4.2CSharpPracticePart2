using System;
using System.Collections.Generic;

namespace _4._2CSharpPracticePart2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student theStudent = new Student("Test", "McTest");
            Classroom theRoom = new Classroom(101);

            // Static method example.
            Student.Sleep();

            Teacher theTeacher = new Teacher("Teacher", "McTest", theRoom);

            //List<Student> someStudents = new List<Student>();
            theTeacher.Class[0] = theStudent;

            //someStudents[0].DoHomework();
            theTeacher.Class[0].DoHomework();


            //theRoom.RoomNumber
            //theTeacher.Room.RoomNumber



        }


    }
}