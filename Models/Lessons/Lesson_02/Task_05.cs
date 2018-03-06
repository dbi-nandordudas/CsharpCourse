using System;
using System.Collections.Generic;
using CsharpCourse.Models.Abstract;

namespace CsharpCourse.Models.Lessons.Lesson_02
{
    public class Task_05 : BaseTask
    {
        public Task_05()
        {
            Description = "Készítsünk programot, amely bekér egy N számot és kiírja a páros számokat 1-től N-ig.";

            ShowInfo();
        }

        public override void Resolve()
        {
            int to;

            Console.WriteLine("Adjon meg egy egész számot!");

            try
            {
                Console.Write("Az adott szám: ");
                to = Convert.ToInt32(Console.ReadLine());

                GenerateNumbers(to, (number) => true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void GenerateNumbers(int to, Func<int, bool> condition, int from = 1, int increase = 1)
        {
            List<int> numbers = new List<int>();

            for (int i = from; i <= to; i += increase)
            {
                if (condition(i))
                {
                    numbers.Add(i);
                }
            }

            Console.WriteLine(String.Join(", ", numbers.ToArray()));
        }
    }
}
