using System;

namespace PBTSample
{
    public class Person
    {
        public string Firstname { get; private set; }
        public Person(string firstname)
        {
            if (firstname.Length >= 7 && firstname.Length <= 9)
                throw new Exception();

            this.Firstname = firstname;
        }
    }
}