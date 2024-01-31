namespace Reference_Types___Value_Types;

class Program
{
    static void Main(string[] args)
    {
        var a = 10;
        //Value types types are copied in a new place in the memory stack, a will remain the same
        var b = a;
        b++;
        Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

        var array1 = new int[3]{1, 2, 3};
        //Reference types share the same assignment on the heap, both types on the stack reference the same object on the heap
        var array2 = array1;
        array2[0] = 0;
        Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));

    }
}

