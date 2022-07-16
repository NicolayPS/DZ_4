using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("У вас 15 попыток");
            int o = 0;
            while (o < 15)
            {


                Console.Write("Введите размер A: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите размер B: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите размер C: ");
                int c = Convert.ToInt32(Console.ReadLine());
                while (a > 0 && b > 0 && c > 0 && c<(a+b))
                {


                    int d = 0;
                    int e = 0;
                    while (a >= c)
                    {
                        a -= c;
                        d++;
                    }
                    while (b >= c)
                    {
                        b -= c;
                        e++;
                    }
                    int count = 0;
                    for (int i = 0; i < d; i++)
                        count += e;
                    Console.WriteLine("Число квадратов = " + count);

                }
                o++;
            }
            Console.WriteLine("Cпасибо!");
            Console.ReadKey();
        }
    }
}
