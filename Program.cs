using System;
using System.Reflection;
using CsharpCourse.Models;

namespace CsharpCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string MethodName = "Resolve";
                string TypeName = "CsharpCourse.Models.Task";
                Type type = Type.GetType(TypeName);

                if (type == null)
                {
                    throw new InvalidOperationException($"{TypeName} model doesn't exists");
                }

                object instance = Activator.CreateInstance(type);
                MethodInfo method = type.GetMethod(MethodName);

                if (method == null)
                {
                    throw new InvalidOperationException($"{MethodName} method doesn't exists");
                }

                method.Invoke(instance, null);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            // Task task = new Task();
            // task.Resolve();
        }
    }
}
