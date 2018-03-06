using System;
using CsharpCourse.Models.Abstract;

namespace CsharpCourse.Models
{
    public class Task : BaseTask
    {
        public Task()
        {
            Description = "My first task's long description. My first task's long description. My first task's long description.";

            ShowInfo();
        }

        public override void Resolve() => Console.WriteLine("My first task's solution!");
    }
}
