using System;
using System.Collections;
using System.Collections.Generic;

namespace IEnumerablesdemo
{
    class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int standard { get; set; }
    }

    class School : IEnumerable
    {
        List<Student> students = new List<Student>();

        public void Add(Student s)
        {
            students.Add(s);
        }

        // Implementing the IEnumerable interface requires implementing GetEnumerator()
        public IEnumerator GetEnumerator()
        {
            // Return the enumerator of the students list
            return students.GetEnumerator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student sd1 = new Student();
            Student sd2 = new Student();
            Student sd3 = new Student();

            sd1.id = 1;
            sd1.name = "Afnan";
            sd1.standard = 12;

            sd2.id = 2;
            sd2.name = "Hassan";
            sd2.standard = 13;

            sd3.id = 3;
            sd3.name = "Ali";
            sd3.standard = 14;

            // Create an instance of the School class
            School students = new School();

            // Add students to the school
            students.Add(sd1);
            students.Add(sd2);
            students.Add(sd3);

            // Using foreach to iterate through the students using IEnumerable
            Console.WriteLine("Using IEnumerable (foreach loop):");
            foreach (Student s in students)
            {
                Console.WriteLine(s.id + "   " + s.name + "   " + s.standard);
            }

            // Using IEnumerator to iterate through the students
            Console.WriteLine("\nUsing IEnumerator (manual iteration):");
            IEnumerator enumerator = students.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Student s = (Student)enumerator.Current;
                Console.WriteLine(s.id + "   " + s.name + "   " + s.standard);
            }
        }
    }
}
