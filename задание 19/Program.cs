/*
Дано уравнение ax2-bx+c=e. Найти х. Math.Pow(x, y), где x – число возводимое в степень, y – показатель степени.
*/

namespace задание_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите коэффициент a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите коэффициент b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите коэффициент c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение e: ");
            double e = Convert.ToDouble(Console.ReadLine());
            c -= e;

            double dis = Math.Pow(b, 2) - 4 * a * c;

            if (dis < 0)
            {
                Console.WriteLine("Нет действительных решений.");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(dis)) / (2 * a);
                double x2 = (-b - Math.Sqrt(dis)) / (2 * a);

                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");

            }
        }
    }
}
