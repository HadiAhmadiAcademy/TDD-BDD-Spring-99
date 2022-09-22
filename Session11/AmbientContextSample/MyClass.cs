using System;

namespace AmbientContextSample
{
    public class MyClass
    {
        public MyClass(DateTime expireDate)
        {
            if (DateTime.Now > expireDate) throw new Exception();
        }
    }
}
