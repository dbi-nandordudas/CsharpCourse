using System;
using System.Collections.Generic;
using System.Reflection;
using CsharpCourse.Models;

namespace CsharpCourse.Providers.Models
{
    public class TaskProvider
    {
        private List<Task> Tasks = new List<Task>();

        public void AddTask(Task task)
        {
            Tasks.Add(task);
        }

        public void ResolveTasks()
        {
            foreach (Task task in Tasks)
            {
                CreateAndInvoke($"{task.GetType().Namespace}.{task.GetType().Name}", "Resolve");
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
