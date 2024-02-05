namespace Arrays;

class Program
{
    static void Main(string[] args)
    {
        var numbers = new int[] { 3, 7, 9, 2, 14, 6 };

        // Length
        Console.WriteLine("Length: " + numbers.Length);

        // IndexOf()
        var index = Array.IndexOf(numbers, 9);
        Console.WriteLine("Index of 9: " + index);

        // Clear(), sets items to 0 (the default)
        // Array, start, how many to set
        Array.Clear(numbers, 0, 2);

        foreach (var n in numbers)
            Console.WriteLine(n);

        // Copy()
        int[] another = new int[3];
        Array.Copy(numbers, another, 3);

        foreach (var n in another)
            Console.WriteLine(n);

        // Sort(), smallest to largest
        Array.Sort(numbers);
        Console.WriteLine(numbers);

        // Reverse()
        Array.Reverse(numbers);
    }
}

