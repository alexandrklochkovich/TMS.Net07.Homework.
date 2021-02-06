using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            ScapeGoat:
            Console.WriteLine("Введите число");
            string somfin = Console.ReadLine(); ;
            int number;
            {
                Console.Clear();
                if (int.TryParse(somfin, out number))
                {
                    Console.WriteLine($"Введено число {number}");
                    if (number != 0)
                    {
                        Console.WriteLine("Продолжайте " +
                              "для завершения работы введите 0");
                        goto ScapeGoat;
                    }
                    else 
                    {
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Это не число");
                }
                Console.ReadLine();
            }
        }
    }
}
