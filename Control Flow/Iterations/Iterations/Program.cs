namespace Iterations;

class Program
{
    static void Main(string[] args)
    {
        var name = "John Smith";
        var numbers = new int[] { 1, 2, 3, 4 };

        // For each loop
        foreach (var character in name)
        {
            Console.WriteLine(character);
        }

        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        //while (true)
        //{
        //    Console.Write("Type your name: ");
        //    var input = Console.ReadLine();

        //    if (!string.IsNullOrWhiteSpace(input)) {
        //        Console.WriteLine("@Echo: " + input);
        //        // This is gonna reset to the beginning of the loop and skip the break
        //        continue;
        //    }

        //    break;
        //}

        // Random class, generates random numbers
        var random = new Random();
        // Generate random numbers
        random.Next();
        // Random numbers between 1 and 10
        random.Next(1, 10);

        for(var i = 0; i < 10; i++)
        {
            // Cast to characters because of ASCII
            Console.WriteLine((char)random.Next(97, 122));
            // Equivalent (a is internally represented as a #)
            Console.WriteLine((char)( 'a' + random.Next(0, 26)));
        }

    }
}

