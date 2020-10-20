using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Stoyan";
            person.Age = 24;

            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);

            Person pesho = new Person("Pesho", 28);
            Console.WriteLine($"{pesho.Name} {pesho.Age}");

            Person gosho = new Person("Gosho", 18);
            Console.WriteLine($"{gosho.Name} {gosho.Age}");

            Person stamat = new Person("Stamat", 43);
            Console.WriteLine($"{stamat.Name} {stamat.Age}");
        }
    }
}
