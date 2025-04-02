/*
Известны объем и масса тела. Определить плотность
материала этого тела. m=p*V, где m – масса, p – плотность, V –
объём.
*/

namespace задание_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("m = ");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.Write("V = ");
            double V = Convert.ToDouble(Console.ReadLine());
            Console.Write("p = V / m = ");
            double p = V / m;
            Console.WriteLine(p);
        }
    }
}
