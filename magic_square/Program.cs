using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magic_square
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Магический квадрат";
            Console.WriteLine("Введите размер квадрата");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 3)
                Console.WriteLine("\nОШИБКА: слишком маленький квадратик :(");
            else
            {
                int[,] square = new int[n, n];
                int sum = 0;
                for (int i = 1; i <= Math.Pow(n, 2); i++)
                {
                    sum = sum + i;
                }
                sum = sum / n;
                Console.WriteLine(sum);

            }
        }
    }
}
