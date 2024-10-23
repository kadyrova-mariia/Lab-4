using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Використання класу для динамічного програмування
            DynamicProgramming dp = new DynamicProgramming();
            Console.WriteLine("Введіть розмір здачі (копійки) для ДП:");
            int n1 = int.Parse(Console.ReadLine());
            int[] coins = { 1, 3, 5, 10 };
            long ways = dp.CountWaysToGiveChange(n1, coins);
            Console.WriteLine($"Кількість способів дати здачу {n1} копійок: {ways}");

            // Використання класу для жадібного алгоритму
            GreedyAlgorithms ga = new GreedyAlgorithms();
            Console.WriteLine("Введіть число n для ЖА:");
            int n2 = int.Parse(Console.ReadLine());
            var decomposition = ga.DecomposeIntoPowersOfTwo(n2);
            Console.WriteLine("Розкладання числа у спадному порядку: " + string.Join(" + ", decomposition));

            Console.ReadKey();
        }
    }
    
}
