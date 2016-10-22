namespace _04_AverageGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AverageGrades
    {
        static void Main()
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] student = Console.ReadLine().Split(' ');
                students.Add(new Student()
                {
                    Name = student[0],
                    Grades = student.Skip(1).Select(double.Parse).ToList()
                });
                
            }

            PrintStudentsAndGrades(students);
        }

        public static void PrintStudentsAndGrades(List<Student> students)
        {
            students = students
                .Where(s => s.AvarageGrade >= 5.00)
                .Select(s => s)
                .OrderBy(s => s.Name)
                .ThenByDescending(g => g.AvarageGrade).ToList();

            foreach (Student student in students)
            {
                Console.WriteLine("{0} -> {1:0.00}", student.Name, Math.Round(student.AvarageGrade, 2));
            }
        }

        public class Student
        {
            public string Name { get; set; }
            public List<double> Grades { get; set; }
            public double AvarageGrade
            {
                get
                {
                    double average = this.Grades.Average();

                    return average;
                }
            }

        }
    }
}
