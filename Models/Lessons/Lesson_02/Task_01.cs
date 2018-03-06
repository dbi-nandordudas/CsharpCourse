using System;
using CsharpCourse.Models.Abstract;

namespace CsharpCourse.Models.Lessons.Lesson_02
{
    public class Task_01 : BaseTask
    {
        public enum Operation : int
        {
            ADD,
            SUBSTRACT,
            MULTIPLY,
            DIVIDE
        }

        public Task_01()
        {
            Description = "Készítsünk programot, amely bekér két egész számot. Majd kiszámolja a két szám összegét, különbségét, szorzatát és hányadosát, úgy hogy a nagyobb számból vonja ki a kisebbet, valamint a nagyobb számot ossza el a kisebbel!";

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

                if (num_01 < num_02)
                {
                    Swap<int>(ref num_01, ref num_02);
                }

                Console.WriteLine($"{num_01} + {num_02} = {GetSumOfTwoNumbers(num_01, num_02, Operation.ADD)}");
                Console.WriteLine($"{num_01} - {num_02} = {GetSumOfTwoNumbers(num_01, num_02, Operation.SUBSTRACT)}");
                Console.WriteLine($"{num_01} * {num_02} = {GetMultiplicationOfTwoNumbers(num_01, num_02, Operation.MULTIPLY)}");
                Console.WriteLine($"{num_01} / {num_02} = {GetMultiplicationOfTwoNumbers(num_01, num_02, Operation.DIVIDE)}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void Swap<T>(ref T num_01, ref T num_02)
        {
            (num_01, num_02) = (num_02, num_01);
        }

        public static int GetSumOfTwoNumbers(int num_01, int num_02, Operation operation)
        {
            switch (operation)
            {
                case Operation.ADD:
                    return num_01 + num_02;
                case Operation.SUBSTRACT:
                    return num_01 - num_02;
                default:
                    throw new InvalidOperationException("Helytelen műveletet akarsz vegrehajtani: (+, -)!");
            }
        }

        public static float GetMultiplicationOfTwoNumbers(int num_01, int num_02, Operation operation)
        {
            switch (operation)
            {
                case Operation.MULTIPLY:
                    return num_01 * num_02;
                case Operation.DIVIDE:
                    return num_01 / (float) num_02;
                default:
                    throw new InvalidOperationException("Helytelen műveletet akarsz vegrehajtani: (*, /)!");
            }
        }
    }
}
