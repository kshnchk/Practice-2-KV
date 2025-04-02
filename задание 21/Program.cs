/*
Найти площадь кольца (S) по заданным внешнему (R) и внутреннему (r) радиусам. S=π(R2 – r2).
*/

namespace задание_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите  R: ");
            double R = double.Parse(Console.ReadLine());
            Console.Write("Введите  r: ");
            double r = double.Parse(Console.ReadLine());
            double S = Math.PI * (Math.Pow(R, 2) - Math.Pow(r, 2));
            Console.WriteLine($"Площадь {S}");
        }
    }
}
