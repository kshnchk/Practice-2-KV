/*
Даны два целых числа. Найти: а) их среднее
арифметическое (сумма делёная на число слагаемых); б) их
среднее геометрическое (корень степени n (double.RootN(x,n), где х
– основание корня, n – степень корня) из произведения n членов).
*/

namespace задание_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToInt32(Console.ReadLine());
            double b = Convert.ToInt32(Console.ReadLine());
            double c = (a + b) / 2;
            double d = (double.RootN(a * b, 2));
            Console.WriteLine($"Среднее арифметическое: {c}");
            Console.WriteLine($"Среднее геометрическое: {d}");
        }
    }
}
