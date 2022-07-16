using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("У вас 15 попыток");
            int o = 0;
            while (o < 15)
            {
                Console.WriteLine("Введите число:");
                int n = Convert.ToInt32(Console.ReadLine());
                int s = 0;
                for (int i = 1; i <= n; i++)
                {
                    s += 2 * i - 1;
                }
                Console.WriteLine(s);
                o++;
            }
            Console.WriteLine("Cпасибо!");
            Console.ReadKey();
        }
    }
}
