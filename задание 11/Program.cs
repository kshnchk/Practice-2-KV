/*
Составить программу вывода на экран числа, вводимого с
клавиатуры. Выводимому числу должно предшествовать сообщение «Вы ввели число».
*/

namespace задание_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Вы ввели число {a}");
        }
    }
}
