/*
Составить программу вывода на экран числа, вводимого с
клавиатуры. После выводимого числа должно следовать
сообщение» — вот какое число Вы ввели».
*/

namespace задание_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a} - вот такое число вы ввели");
        }
    }
}
