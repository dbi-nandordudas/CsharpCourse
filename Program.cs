using System;
using System.Text.RegularExpressions;
using CsharpCourse.Models;
using CsharpCourse.Providers.Models;

namespace CsharpCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TaskProvider taskProvider = new TaskProvider();

                taskProvider.AddTask("CsharpCourse.Models.Lessons.Lesson_01.Task_01");

                taskProvider.ResolveTasks();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
