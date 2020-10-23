using System;

namespace _4._2CSharpPracticePart2
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher mathTeacher = new Teacher("Bob", "Jones", new Classroom(101));

            Student joe = new Student("Joe", "Smith");
            Student sally = new Student("Sally", "Howard");

            mathTeacher.Class.Add(joe);
            mathTeacher.Class.Add(sally);

            Console.WriteLine(joe);
            Console.WriteLine(sally);

            mathTeacher.AssignHomework();

            Console.WriteLine(joe);
            Console.WriteLine(sally);

            joe.Sleep();
            joe.Sleep();
            joe.Sleep();
            Console.WriteLine(joe);

        }
    }
}