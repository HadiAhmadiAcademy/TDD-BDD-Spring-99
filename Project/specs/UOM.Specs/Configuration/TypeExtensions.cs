using System;
using System.Linq;
using Suzianna.Core.Screenplay;
using Suzianna.Core.Screenplay.Questions;

namespace UOM.Specs.Configuration
{
    public static class TypeExtensions
    {
        public static bool IsTask(this Type type)
        {
            return typeof(ITask).IsAssignableFrom(type);
        }

        public static bool IsQuestion(this Type type)
        {
            return type.GetInterfaces()
                .Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IQuestion<>));
        }
    }
}