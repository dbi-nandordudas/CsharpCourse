using System;
using CsharpCourse.Models.Abstract;

namespace CsharpCourse.Models.Lessons.Lesson_01
{
    public class Task_01 : BaseTask
    {
        public Task_01()
        {
            Description = "Készítsen programot, amely bekér két számot és kiírja az alábbi formában a velük elvégzett műveletek eredményét.";

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

                Console.WriteLine($"{num_01} + {num_02} = {num_01 + num_02}");
                Console.WriteLine($"{num_01} * {num_02} = {num_01 * num_02}");
                Console.WriteLine($"{num_01} - {num_02} = {num_01 - num_02}");
                Console.WriteLine($"{num_01} / {num_02} = {num_01 / (float)num_02}");
                Console.WriteLine($"{num_01} % {num_02} = {num_01 % num_02}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
