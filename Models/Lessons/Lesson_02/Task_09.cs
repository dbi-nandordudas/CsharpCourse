using System;
using System.Collections.Generic;
using CsharpCourse.Models.Abstract;

namespace CsharpCourse.Models.Lessons.Lesson_02
{
    public class Task_09 : BaseTask
    {
        public Task_09()
        {
            Description = "Készítsünk programot, mely kiszámítja egy szám faktoriálisát.";

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

                Console.WriteLine($"A(z) {num} faktoriálisa: {GetFactorial(num)}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static int GetFactorial(int number) => number > 1 ? (number * GetFactorial(number - 1)) : 1;
    }
}
