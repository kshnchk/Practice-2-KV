/*
Вывести на экран число e (Math.E) с точностью до десятых.
*/

namespace задание_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double e = Math.E;
            double a = Math.Round(e, 1);
            Console.WriteLine(a);
        }
    }
}
