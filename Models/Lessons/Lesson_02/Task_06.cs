using System;
using System.Collections.Generic;
using CsharpCourse.Models.Abstract;

namespace CsharpCourse.Models.Lessons.Lesson_02
{
    public class Task_06 : BaseTask
    {
        public Task_06()
        {
            Description = "Készítsünk programot, mely a következő feladatot látja el: Bekér a felhasználótól egy számot, majd eldönti róla, hogy az adott szám prímszám-e. A program írja ki, hogy a felhasználó által megadott szám osztóit, illetve, hogy az adott számnak hány osztója van az egyen és önmagán kívül.";

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

                GetAllFactors(num);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static bool isDivider(int num_01, int num_02) => num_01 % num_02 == 0;

        public static void GetAllFactors(int number)
        {
            int count = 0;
            List<int> factors = new List<int>();

            for (int i = number - 1; i > 1; i--)
            {
                if (isDivider(number, i))
                {
                    factors.Add(i);
                    count++;
                }
            }

            if (factors.Count > 0)
            {
                Console.WriteLine($"A(z) {number} osztói: {String.Join(", ", factors.ToArray())}");
            }

            Console.WriteLine($"A(z) {number}-n(ae)k {count} darab osztója van, önmagan és az 1-en kívül");
        }
    }
}
