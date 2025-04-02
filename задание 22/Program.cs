/*
Даны катеты прямоугольного треугольника. Найти его периметр (P=a+b+c).
*/

namespace задание_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите  a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите  b: ");
            double b = double.Parse(Console.ReadLine());
            double c = Math.Sqrt(a * a + b * b);
            double p = a + b + c;
            Console.WriteLine($"Периметр {p}");
        }
    }
}
