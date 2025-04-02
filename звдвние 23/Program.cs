/*
Даны два числа. Найти среднее арифметическое и
среднее геометрическое их модулей. Math.Abs(n), где n – число вычисляемого модуля.
*/

namespace задвние_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите num1:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите num2 :");
            double num2 = double.Parse(Console.ReadLine());

            double absNum1 = Math.Abs(num1);
            double absNum2 = Math.Abs(num2);
            double ar = (absNum1 + absNum2) / 2;
            Console.WriteLine($"Ср арифметическое {ar}");
            double geom = Math.Sqrt(absNum1 * absNum2);
            Console.WriteLine($"Ср геометрическое {geom}");
        }
    }
}
