using System;
using CsharpCourse.Models.Abstract;

namespace CsharpCourse.Models.Lessons.Lesson_02
{
    public class Task_02 : BaseTask
    {
        public enum Operation : int
        {
            ADD,
            SUBSTRACT,
            MULTIPLY,
            DIVIDE
        }

        public Task_02()
        {
            Description = "Készítsünk programot, mely bekér a felhasználótól egy számot, majd kiírja az adott számról, hogy páros, páratlan, vagy nulla.";

            ShowInfo();
        }

        public override void Resolve()
        {
            int num;
            string isZero, isEven;

            Console.WriteLine("Adjon meg egy egész számot!");

            try
            {
                Console.Write("A megadott szám: ");
                num = Convert.ToInt32(Console.ReadLine());

                isZero = IsZero(num) ? "nulla" : "nem nulla";
                isEven = IsEven(num) ? "páros" : "páratlan";

                Console.WriteLine($"A {num} egy {isZero} {isEven} egész szám");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static bool IsZero(int number) => number == 0;

        public static bool IsEven(int number) => number % 2 == 0;
    }
}
