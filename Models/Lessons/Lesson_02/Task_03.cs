using System;
using CsharpCourse.Models.Abstract;

namespace CsharpCourse.Models.Lessons.Lesson_02
{
    public class Task_03 : BaseTask
    {
        public Task_03()
        {
            Description = "Készítsünk programot, amely bekér a felhasználótól két számot. A program döntse el, hogy az elsőként bekért számnak osztója-e a másodikként bekért szám. Amennyiben igen, írja ki az osztás eredményét is.";

            ShowInfo();
        }

        public override void Resolve()
        {
            int num_01, num_02;

            Console.WriteLine("Adjon meg két egész számot!");

            try
            {
                Console.Write("Első szám: ");
                num_01 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Második szám: ");
                num_02 = Convert.ToInt32(Console.ReadLine());

                if (IsDivider(num_01, num_02))
                {
                    Console.WriteLine(num_01 / (float) num_02);
                }
                else
                {
                    Console.WriteLine($"A(z) {num_02} nem osztoja a(z) {num_01}-n(ae)k");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public static bool IsDivider(int num_01, int num_02) => num_01 % num_02 == 0;
    }
}
