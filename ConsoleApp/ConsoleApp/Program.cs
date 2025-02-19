using System;
using System.Text;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        try
        {
            double num1 = ReadNumber("Введіть перше число: ");
            double num2 = ReadNumber("Введіть друге число: ");

            double sum = num1 + num2;
            Console.WriteLine($"Сума чисел {num1} і {num2} дорівнює: {sum}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Сталася помилка: {ex.Message}");
        }
    }

    static double ReadNumber(string message)
    {
        double number;
        Console.Write(message);
        while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out number))
        {
            Console.WriteLine("Помилка! Введіть коректне число.");
            Console.Write(message);
        }
        return number;
    }
}
