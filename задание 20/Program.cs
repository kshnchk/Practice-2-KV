/*
Даны катеты (a, b) прямоугольного треугольника. Найти его гипотенузу (c). a2+b2=c2
*/

namespace задание_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину катета a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите длину катета b: ");
            double b = double.Parse(Console.ReadLine());
            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine($"гепотинуза  {c}");
        }
    }
}
