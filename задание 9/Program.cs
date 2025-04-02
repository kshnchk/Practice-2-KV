/*
Вывести на экран число с точностью до сотых
(Math.Round(с,n), где с – округляемое число, n – число знаков после запятой).
*/

namespace задание_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c = Double.Parse(Console.ReadLine());
            double a = Math.Round(c, 2);
            Console.WriteLine(a);
        }
    }
}
