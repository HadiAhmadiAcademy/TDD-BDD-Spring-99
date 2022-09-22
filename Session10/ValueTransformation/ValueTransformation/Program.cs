using System;
using FizzWare.NBuilder;
using ValueTransformation.Framework;

namespace ValueTransformation
{
    class Program
    {
        static void Main(string[] args)
        {
            //var people = Builder<Person>.CreateListOfSize(3)
            //    .All()
            //    .With(a => a.Firstname = Faker.Name.First())
            //    .With(a => a.Lastname = Faker.Name.Last())
            //    .With(a => a.Email = Faker.Internet.Email())
            //    .With(a => a.Address = Faker.Address.SecondaryAddress())
            //    .With(a => a.Website = Faker.Internet.DomainName())
            //    .Build();
                
            //foreach (var person in people)
            //{
            //    Console.WriteLine(person.Firstname);
            //    Console.WriteLine(person.Lastname);
            //    Console.WriteLine(person.Email);
            //    Console.WriteLine(person.Website);
            //    Console.WriteLine(person.Address);
            //    Console.WriteLine("---------------------------");
            //}

            var person = new Person()
            {
                Id = 1, 
                Firstname = "Jack",
                Lastname = "Smith",
                Email = "jack@yahoo.com"
            };

            var transformed = ObjectTransformer.Transform(person);
            Console.WriteLine(transformed.Firstname);
            Console.WriteLine(transformed.Email);

            Console.ReadLine();
        }
    }
}
