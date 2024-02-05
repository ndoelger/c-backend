namespace Lists;

class Program
{
    static void Main(string[] args)
    {
        var numbers = new List<int>() { 1,2,3,4};

        // Adds
        numbers.Add(1);
        // AddRange
        numbers.AddRange(new int[3] {5,6,7});

        foreach (var n in numbers)
            Console.WriteLine(n);

        // IndexOf
       Console.WriteLine(numbers.IndexOf(1));

        // LastIndexOf
       Console.WriteLine(numbers.LastIndexOf(1));

        // Count
        Console.WriteLine(numbers.Count);

        //Remove (specific value)
        numbers.Remove(1);
        numbers.Remove(1);
        numbers.Remove(1);


        foreach (var n in numbers)
            Console.WriteLine(n);
    }
}

