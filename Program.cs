using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите операцию (^, sqrt, +, -, *, /):");
        string operation = Console.ReadLine();

        Console.WriteLine("Введите второе число:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;

        switch (operation)
        {
            case "^":
                result = Math.Pow(num1, num2);
                break;
            case "sqrt":
                result = Math.Sqrt(num1);
                break;
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                result = num1 / num2;
                break;
            default:
                Console.WriteLine("Неизвестная операция");
                break;
        }

        Console.WriteLine($"Результат: {result}");
        Console.ReadLine();
    }
}
