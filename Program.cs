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

                CreateAndInvoke(TypeName, MethodName);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        public static object CreateAndInvoke(string typeName, string methodName, object[] methodArgs = null)
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
