/*
Создать на основе п.2 программу, которая вводит с
клавиатуры числа a и b, указывающие диапазон случайных чисел и
выводит случайное число из этого диапазонаю.
*/

namespace задание_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int numa = int.Parse(a);
            int numb = int.Parse(b);
            Random rnd = new Random();
            Console.WriteLine(rnd.Next(numa, numb));
        }
    }
}
