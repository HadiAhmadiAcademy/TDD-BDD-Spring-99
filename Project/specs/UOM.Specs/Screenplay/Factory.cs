using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Suzianna.Core.Screenplay;
using Suzianna.Core.Screenplay.Questions;
using UOM.Specs.Configuration;

namespace UOM.Specs.Screenplay
{
    public static class Factory
    {
        private static Dictionary<string, Type> _cachedTypes;
        static Factory()
        {
            _cachedTypes = Config.Current.ExecutionAssembly
                .GetExportedTypes()
                .Where(a => a.IsTask() || a.IsQuestion())
                .ToDictionary(a => a.BaseType.Name, a => a);
        }

        public static T CreateTask<T>(params object[] parameters) where T : ITask
        {
            var type = _cachedTypes[typeof(T).Name];
            return (T) Activator.CreateInstance(type, parameters);
        }
        public static T CreateQuestion<T>(params object[] parameters)
        {
            var type = _cachedTypes[typeof(T).Name];
            return (T)Activator.CreateInstance(type, parameters);
        }

    }
}