using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.DaysOfWeak
{
    class Program
    {

        static void Main(string[] args)
        {
            ScapeGoat:
            Console.WriteLine("Введите день недели");
            string day = Console.ReadLine();

            switch (day)
            {
                case ("Monday"):
                    Console.WriteLine("Понедельник");
                    break;
                case ("Tuesday"):
                    Console.WriteLine("Вторник");
                    break;
                case ("Wednesday"):
                    Console.WriteLine("Среда");
                    break;
                case ("Thursday"):
                    Console.WriteLine("Четверг");
                    break;
                case ("Friday"):
                    Console.WriteLine("Пятница");
                    break;
                case ("Saturday"):
                    Console.WriteLine("Суббота");
                    break;
                case ("Sunday"):
                    Console.WriteLine("Воскресенье");
                    break;
                case ("Exit"):
                    return;
                default:
                    Console.WriteLine("Не день недели");
                    break;
            }
            Console.ReadLine();
            Console.Clear();
            goto ScapeGoat;
        }
    }
}
