using System;

class Program
{

    static void Main(string[] args)
    {
        double result1 = Calculate(5, 7);
        double result2 = Calculate(12, 15);
        double result3 = Calculate(22, 32);
        double totalResult = result1 + result2 + result3;

        Console.WriteLine($"Результат 1: {result1}");
        Console.WriteLine($"Результат 2: {result2}");
        Console.WriteLine($"Результат 3: {result3}");
        Console.WriteLine($"Загальна сума: {totalResult}");

         double Calculate(double x, double y)
        {
            return (Math.Sqrt(x) + x) / (y + Math.Sqrt(y));
        }
        Console.ReadKey();
    }
}

