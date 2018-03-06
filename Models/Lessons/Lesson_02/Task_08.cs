using System;
using System.Collections.Generic;
using CsharpCourse.Models.Abstract;

namespace CsharpCourse.Models.Lessons.Lesson_02
{
    public class Task_08 : BaseTask
    {
        public Task_08()
        {
            Description = "Készítsünk programot, mely elvégzi egy szám prímtényezős felbontását.";

            ShowInfo();
        }

        public override void Resolve()
        {
            int num;

            Console.WriteLine("Adjon meg egy egész számot!");

            try
            {
                Console.Write("Az adott szám: ");
                num = Convert.ToInt32(Console.ReadLine());

                GetAllFactorsByPrime(num);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static bool isDivider(int num_01, int num_02) => num_01 % num_02 == 0;

        public static void GetAllFactorsByPrime(int number)
        {
            List<int> numbers = new List<int>();

            for (int i = 2; i <= number; i++)
            {
                while (isDivider(number, i))
                {
                    numbers.Add(i);
                    number /= i;
                }
            }

            Console.WriteLine($"A(z) {number} prímtényezős felbontása: {String.Join(", ", numbers.ToArray())}");
        }
    }
}
