using System;
using CsharpCourse.Models.Abstract;

namespace CsharpCourse.Models.Lessons.Lesson_01
{
    public class Task_01 : BaseTask
    {
        public Task_01()
        {
            Description = "My first task's long description. My first task's long description. My first task's long description.";

            ShowInfo();
        }

        public override void Resolve() => Console.WriteLine("My first task's solution!");
    }
}
