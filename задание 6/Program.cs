/*
Создайте 3 числа.
float a = 3.2f;
decimal b = 2.6m;
double c = 4.5;
Запишите в с сумму всех трёх чисел. Исправьте возникающие
ошибки с помощью явного преобразования данных.
*/

namespace задание_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 3.2f;
            decimal b = 2.6m;
            double c = 4.5;
            c += (double)a + (double)b;
            Console.WriteLine(c);
        }
    }
}
