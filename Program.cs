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
                string taskName = ArgumentSupport.GetTaskFromCommandLine(args);

                TaskProvider taskProvider = new TaskProvider();

                taskProvider.AddTask(taskName);

                taskProvider.ResolveTasks();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    static class ArgumentSupport
    {
        static int lessonNumber, taskNumber;
        static string lessonName, taskName;
        static string pattern = "^\\d{1}$";
        static string replacement = "0$0";
        static Regex regex = new Regex(pattern);

        public static string GetTaskFromCommandLine(string[] args)
        {
            if (args?.Length > 0)
            {
                switch (args.Length)
                {
                    case 2:
                        lessonNumber = (args[0] == "--lesson") ? int.Parse(args[1]) : 1;
                        lessonName = "Lesson_" + regex.Replace(lessonNumber.ToString(), replacement);

                        return $"CsharpCourse.Models.Lessons.{lessonName}.Task_01";
                    case 4:
                        lessonNumber = (args[0] == "--lesson") ? int.Parse(args[1]) : 1;
                        lessonName = "Lesson_" + regex.Replace(lessonNumber.ToString(), replacement);

                        taskNumber = (args[2] == "--task") ? int.Parse(args[3]) : 1;
                        taskName = "Task_" + regex.Replace(taskNumber.ToString(), replacement);

                        return $"CsharpCourse.Models.Lessons.{lessonName}.{taskName}";
                    default:
                        return $"CsharpCourse.Models.Lessons.Lesson_01.Task_01";
                }
            }

            return $"CsharpCourse.Models.Lessons.Lesson_01.Task_01";
        }
    }
}
