/*
Написать программу
int a, b, c; = b = c = 2;
double z = a * b + c++ / b - a * b * --c;
Изменить код с помощью круглых скобок, чтобы результат
был равен
а) 3.66; б) -1; в) 2; г) -2; д) -4
*/

namespace задание_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = b = c = 2;

            double z1 = (a * b + (double)c) / b - a * b * --c;
            Console.WriteLine($"а: {z1}");


            double z2 = a * b + c++ / (b - a * (b * --c));
            Console.WriteLine($"б: {z2}");


            double z3 = (a * b + (c++ / b)) - a * (b * --c);
            Console.WriteLine($"в: {z3}");


            double z4 = a * (b + c++) / b - a * b * --c;
            Console.WriteLine($"г: {z4}");


            double z5 = a * b + c++ / b - (a * b * --c);
            Console.WriteLine($"д: {z5}");
        }
    }
}
