/*using System;

namespace StudentManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[100];
            int studentCount = 0;

            Console.WriteLine("Welcome to the Student Management System!\n");

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View Students");
                Console.WriteLine("3. Search Student");
                Console.WriteLine("4. Update Student");
                Console.WriteLine("5. Delete Student");
                Console.WriteLine("6. Exit");
                Console.Write("\nEnter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter student name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter student age: ");
                        int age = int.Parse(Console.ReadLine());

                        Console.Write("Enter student course: ");
                        string course = Console.ReadLine();

                        Console.Write("Enter student grade: ");
                        char grade = char.Parse(Console.ReadLine());

                        students[studentCount++] = new Student(name, age, course, grade);
                        Console.WriteLine("\nStudent added successfully!\n");
                        break;

                    case 2:
                        Console.WriteLine("\nStudent List:");
                        for (int i = 0; i < studentCount; i++)
                        {
                            students[i].DisplayInfo();
                        }
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.Write("Enter student name to search: ");
                        string searchName = Console.ReadLine();

                        bool found = false;
                        foreach (var student in students)
                        {
                            if (student != null && student.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase))
                            {
                                student.DisplayInfo();
                                found = true;
                                break;
                            }
                        }

                        if (!found)
                        {
                            Console.WriteLine("Student not found.\n");
                        }
                        break;

                    case 4:
                        Console.Write("Enter student name to update: ");
                        string updateName = Console.ReadLine();

                        bool updated = false;
                        foreach (var student in students)
                        {
                            if (student != null && student.Name.Equals(updateName, StringComparison.OrdinalIgnoreCase))
                            {
                                Console.Write("Enter updated age: ");
                                student.Age = int.Parse(Console.ReadLine());

                                Console.Write("Enter updated course: ");
                                student.Course = Console.ReadLine();

                                Console.Write("Enter updated grade: ");
                                student.Grade = char.Parse(Console.ReadLine());

                                Console.WriteLine("\nStudent updated successfully!\n");
                                updated = true;
                                break;
                            }
                        }

                        if (!updated)
                        {
                            Console.WriteLine("Student not found.\n");
                        }
                        break;

                    case 5:
                        Console.Write("Enter student name to delete: ");
                        string deleteName = Console.ReadLine();

                        bool deleted = false;
                        for (int i = 0; i < studentCount; i++)
                        {
                            if (students[i] != null && students[i].Name.Equals(deleteName, StringComparison.OrdinalIgnoreCase))
                            {
                                for (int j = i; j < studentCount - 1; j++)
                                {
                                    students[j] = students[j + 1];
                                }
                                students[studentCount - 1] = null;
                                studentCount--;
                                Console.WriteLine("\nStudent deleted successfully!\n");
                                deleted = true;
                                break;
                            }
                        }

                        if (!deleted)
                        {
                            Console.WriteLine("Student not found.\n");
                        }
                        break;

                    case 6:
                        Console.WriteLine("\nExiting the program. Goodbye!\n");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.\n");
                        break;
                }
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }
        public char Grade { get; set; }

        public Student(string name, int age, string course, char grade)
        {
            Name = name;
            Age = age;
            Course = course;
            Grade = grade;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Course: {Course}, Grade: {Grade}");
        }
    }
}
*/

