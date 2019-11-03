using System;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new BaseEmailBuilder();
            var director = new BuilderDirector(builder);
            var email = director.Build();
            Console.WriteLine(email);
        }
    }
}