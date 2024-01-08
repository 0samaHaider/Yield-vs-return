namespace Yield;

class Program
{
    static void Main()
    {
        // Using GetNumbersWithReturn
        Console.WriteLine("Using GetNumbersWithReturn:");
        var numbersList = GetNumbersWithReturn();
        foreach (var num in numbersList)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine();

        // Using GetNumbersWithYield
        Console.WriteLine("Using GetNumbersWithYield:");
        foreach (var num in GetNumbersWithYield())
        {
            Console.WriteLine(num);
        }

        Console.ReadLine(); // To keep the console window open
    }

    public static List<int> GetNumbersWithReturn()
    {
        var numbers = new List<int>();
        numbers.Add(1);
        Console.WriteLine("Number 1 Added");

        numbers.Add(2);
        Console.WriteLine("Number 2 Added");

        numbers.Add(3);
        Console.WriteLine("Number 3 Added");

        return numbers;
    }

    public static IEnumerable<int> GetNumbersWithYield()
    {
        yield return 1;
        Console.WriteLine("Number 1 Yielded");

        yield return 2;
        Console.WriteLine("Number 2 Yielded");

        yield return 3;
        Console.WriteLine("Number 3 Yielded");
    }
}