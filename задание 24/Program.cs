/*
Дано вещественное число а. Пользуясь только операцией
умножения, получить:
а) a4 за две операции;
int a = int.Parse(Console.ReadLine()); //a1
a = a * a; //a1*a1=a1+1=a2
a = a * a; //a2*a2=a2+2=a4
б) a6  за три операции;
в) a7 за четыре операции;
г) a8  за три операции;
д) a9 за четыре операции;
е) a10  за четыре операции.
*/

using System;

namespace задание_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a:");
            double a = double.Parse(Console.ReadLine());

            double a2 = a * a;
            double a4 = a2 * a2;
            Console.WriteLine($"a4 = {a4}");


            double a6 = a4 * a * a;
            Console.WriteLine($"a6 = {a6}");


            double a7 = a4 * a * a * a;
            Console.WriteLine($"a7 = {a7}");


            double a8 = a6 * a * a;
            Console.WriteLine($"a8 = {a8}");


            double a9 = a6 * a * a * a;
            Console.WriteLine($"a9 = {a9}");


            double a10 = a7 * a * a * a;
            Console.WriteLine($"a10 = {a10}");
        }
    }
}
