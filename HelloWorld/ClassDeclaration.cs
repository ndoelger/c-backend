using System;
using HelloWorld.Math;

namespace HelloWorld
{
    
    class ClassDeclaraion
    {
        static void Main(string[] args)
        {
            Person john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            var result = Calculator.Add(1, 2);
            Console.WriteLine(result);
            
        }
    }

}