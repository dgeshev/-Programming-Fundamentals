using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Exercises
{
    public class ClassExercise
    {
        public string Topic { get; set; }
        public string CourseName { get; set; }
        public string JudgeContestLink { get; set; }
        public List<string> Problems { get; set; }
    }

    public class Exercises
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var resultExercise = new List<ClassExercise>();

            while (input != "go go go")
            {
                var tokens = input.Split(new[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

                var topic = tokens[0];
                var courseName = tokens[1];
                var judgeContestLink = tokens[2];
                var problems = tokens.Skip(3).ToList();

                var newExercise = new ClassExercise();
                newExercise.Topic = topic;
                newExercise.CourseName = courseName;
                newExercise.JudgeContestLink = judgeContestLink;
                newExercise.Problems = problems;

                resultExercise.Add(newExercise);

                input = Console.ReadLine();
            }

            foreach (var exercise in resultExercise)
            {
                Console.WriteLine($"Exercises: {exercise.Topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{exercise.CourseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {exercise.JudgeContestLink}");

                var count = 1;

                foreach (var problem in exercise.Problems)
                {
                    Console.WriteLine($"{count}. {problem}");
                    count++;
                }

            }
        }
    }
}
