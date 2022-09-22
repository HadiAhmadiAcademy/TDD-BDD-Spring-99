using System;
using System.Collections.Generic;
using Sample.Employees;

namespace Sample.Tests.TestDoubles
{
    public class HandMadeMockEmployeeRepository : IEmployeeRepository
    {
        Dictionary<string, MethodCall> _methodCalls = new Dictionary<string, MethodCall>();

        public void Create(Employee employee)
        {
            if (_methodCalls.ContainsKey(nameof(Create)))
                _methodCalls[nameof(Create)].IncreaseCalledTimes();
            else
                _methodCalls.Add(nameof(Create), new MethodCall(employee, 1));
        }

        public MethodCall GetCalled(string methodName)
        {
            return _methodCalls[methodName];
        }
    }

    public class MethodCall
    {
        public object PassedArgument { get; set; }
        public int CalledTimes { get; set; }
        public MethodCall(object passedArgument, int calledTimes)
        {
            PassedArgument = passedArgument;
            CalledTimes = calledTimes;
        }

        public void IncreaseCalledTimes()
        {
            this.CalledTimes++;
        }
    }
}