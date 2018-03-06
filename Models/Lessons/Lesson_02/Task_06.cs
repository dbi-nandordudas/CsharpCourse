using System;
using System.Collections.Generic;
using CsharpCourse.Models.Abstract;

namespace CsharpCourse.Models.Lessons.Lesson_02
{
    public class Task_06 : BaseTask
    {
        public Task_06()
        {
            Description = "Készítsünk programot, mely a következő feladatot látja el: Bekér a felhasználótól egy számot, majd a megadott számig kiírja a prímszámokat.";

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

                GenerateNumbers(to, IsPrime);
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

        public static bool IsPrime(int number)
        {
            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); ++i)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
