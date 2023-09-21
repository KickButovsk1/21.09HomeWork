using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanieindpilipenko
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            double alpha;
            string str = Console.ReadLine();
            bool alphaa = Double.TryParse(str, out alpha);//преобразуем в double
            if (alphaa==true)
            {
                double a = Convert.ToDouble(Console.ReadLine());
                double y = (1 - 2 * Math.Pow(Math.Sin(a), 2));
                double y1 = (1 + Math.Sin(2 * a));
                double z = (1 - Math.Tan(a));
                double z1 = (1 + Math.Tan(a));
                if (y1 == 0)
                {
                    Console.WriteLine("Знаменатель y равен 0");
                }
                else
                {
                    Console.WriteLine("y = {0:0.##} ", y / y1);
                }
                if (z1 == 0)
                {
                    Console.WriteLine("Знаменатель z равен 0");
                }
                else
                {
                    Console.WriteLine("z = {0:0.##} ", z / z1);
                        
                }
            }

            Console.ReadKey();


        }
    }
}
