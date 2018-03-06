using System;
using System.Collections.Generic;
using System.Reflection;
using CsharpCourse.Models;

namespace CsharpCourse.Providers.Models
{
    public class TaskProvider
    {
        private List<string> Tasks = new List<string>();

        public void AddTask(string task)
        {
            Tasks.Add(task);
        }

        public void ResolveTasks()
        {
            foreach (string task in Tasks)
            {
                CreateAndInvoke(task, "Resolve");
            }
        }

        private static object CreateAndInvoke(string typeName, string methodName, object[] methodArgs = null)
        {
            Type type = Type.GetType(typeName);

            if (type == null)
            {
                throw new InvalidOperationException($"{typeName} model doesn't exists");
            }

            object instance = Activator.CreateInstance(type);
            MethodInfo method = type.GetMethod(methodName);

            if (method == null)
            {
                throw new InvalidOperationException($"{methodName} method doesn't exists");
            }

            return method.Invoke(instance, methodArgs);
        }
    }
}
