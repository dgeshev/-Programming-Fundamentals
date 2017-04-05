using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.JSONparse
{
    public class JSONparse
    {
        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public List<int> Grades { get; set; }

        }

        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { '}' });

            var result = new List<Student>();

            for (int i = 0; i < input.Length - 1; i++)
            {
                var separated = input[i].Split(new[] { '{', '}', '[', ']', ' ', ':', ',', '"' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var name = separated[1];
                var age = int.Parse(separated[3]);
                var grades = separated.Skip(5).Select(int.Parse).ToList();

                var newStudent = new Student();

                newStudent.Name = name;
                newStudent.Age = age;
                newStudent.Grades = grades;

                result.Add(newStudent);
            }

            foreach (var student in result)
            {
                if (student.Grades.Count >= 1)
                {
                    Console.WriteLine($"{student.Name} : {student.Age} -> {string.Join(", ", student.Grades)}");
                }

                else
                {
                    Console.WriteLine($"{student.Name} : {student.Age} -> None");
                }
            }

        }
    }
}
