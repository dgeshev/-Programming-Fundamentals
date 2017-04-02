using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.JSONStringify
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<int> Grades { get; set; }
    }

    public class JSONStringify
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var result = new List<Student>();

            while (input != "stringify")
            {
                var tokens = input.Split(new[] { ' ', '-', '>', ',', ':' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var name = tokens[0];
                var age = int.Parse(tokens[1]);
                var grades = new List<int>();

                for (int i = 2; i < tokens.Count; i++)
                {
                    grades.Add(int.Parse(tokens[i]));
                }

                var newStudent = new Student();

                newStudent.Name = name;
                newStudent.Age = age;
                newStudent.Grades = grades;
                result.Add(newStudent);

                input = Console.ReadLine();
            }
            Console.Write("[");

            foreach (var st in result)
            {
                if (st == result.Last())
                {
                    Console.Write($"{{name:\"{st.Name}\",age:{st.Age},grades:[{string.Join(", ", st.Grades)}]}}");
                }
                else
                {
                    Console.Write($"{{name:\"{st.Name}\",age:{st.Age},grades:[{string.Join(", ", st.Grades)}]}},");
                }
            }

            Console.WriteLine("]");
        }
    }
}
