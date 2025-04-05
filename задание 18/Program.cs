/*
Составить программу решения уравнения ax+b=0 (a ≠ 0). a и b ввести с клавиатуры.
*/

namespace задание_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение a (a ≠ 0): ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double x = -b / a;
            Console.WriteLine($"Решение уравнения {a}x + {b} = 0: x = {x}");
        }
    }
}
