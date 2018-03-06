using System;
using CsharpCourse.Models.Abstract;

namespace CsharpCourse.Models.Lessons.Lesson_02
{
    public class Task_04 : BaseTask
    {
        public Task_04()
        {
            Description = "Készítsünk programot, mely eldönti egy háromszög három oldala alapján, hogy az adott háromszög szerkeszthető-e.";

            ShowInfo();
        }

        public override void Resolve()
        {
            int side_A, side_B, side_C;
            string creatable;

            Console.WriteLine("Adja meg a hármoszög oldalait egész számmal!");

            try
            {
                Console.Write("Első oldal: ");
                side_A = Convert.ToInt32(Console.ReadLine());

                Console.Write("Második oldal: ");
                side_B = Convert.ToInt32(Console.ReadLine());

                Console.Write("Harmadik oldal: ");
                side_C = Convert.ToInt32(Console.ReadLine());

                creatable = Triangle.isCreatable(side_A, side_B, side_C) ? "szerkeszthető" : "nem szerkeszthető";

                Console.WriteLine($"A háromszög, amelynek oldalai {side_A}, {side_B} és {side_C} {creatable}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static class Triangle
        {
            public static bool isCreatable(int side_a, int side_b, int side_c)
            {
                return side_a < (side_b + side_c) &&
                    side_b < (side_a + side_c) &&
                    side_c < (side_a + side_b);
            }
        }
    }
}
