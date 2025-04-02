/*
Ввести с клавиатуры четырёхзначное число. Найти сумму
и произведение его цифр. Для нахождения цифр числа
использовать операции деления (/) и остатка от деления (%).
*/

namespace задание_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 4x число:");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int pr = 1;

            int num1 = num % 10;
            sum += num1;
            pr *= num1;

            num /= 10;

            int num2 = num % 10;
            sum += num2;
            pr *= num2;

            num /= 10;

            int num3 = num % 10;
            sum += num3;
            pr *= num3;

            num /= 10;

            int num4 = num % 10;
            sum += num4;
            pr *= num4;

            Console.WriteLine($"Сумма {sum}");
            Console.WriteLine($"Произведение {pr}");
        }
    }
}
