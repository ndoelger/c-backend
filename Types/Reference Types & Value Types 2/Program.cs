namespace Reference_Types___Value_Types_2;

public class Person
{
    public int Age;
}

class Program
{
    static void Main(string[] args)
    {
        var number = 1;
        // Won't change because the incrememnt is outside the scope
        Increment(number);

        var person = new Person() { Age = 20 };
        // This will change because it's a reference type
        MakeOld(person);
    }

    public static void Increment(int number)
    {
        // Value created, incremented, then destroyed
        number += 10;
    }

    public static void MakeOld(Person person)
    {
        person.Age += 10;
    }
}

