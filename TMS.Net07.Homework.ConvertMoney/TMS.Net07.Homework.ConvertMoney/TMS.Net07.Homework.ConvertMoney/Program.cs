using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.ConvertMoney
{
    class Program
    {
        enum ExchangeSellCourses
        {
            USDtoBYN = 26590,
            EURtoBYN = 31630,
            RUBtoBYN = 342,
            EURtoUSD = 12120,
            EURtoRUB = 932300,
            USDtoRUB = 774700,
        }

        enum ExchangeBuyCourses
        {
            BYNtoUSD = 26240,
            BYNtoEUR = 31960,
            BYNTORUB = 352,
            USDtoEUR = 11940,
            RUBtoEUR = 907600,
            RUBtoUSD = 754200
        }
        static void Main(string[] args)
        {
            ExchangeSellCourses SellCourse;
            ExchangeBuyCourses BuyCourse;

            string sourceCurrency;
            string targetCurrency;
            string amountInput;

            bool sellCheck;
            bool buyCheck;
            bool amountCheck;

            double amount;
            double amountAfterExchange;

            do
            {
                Console.Write("Введите (e.g. BYN, USD, EUR, RUB): ");
                sourceCurrency = Console.ReadLine().ToUpper(); // ToUpper - возвращает копию этой строки переведенную в верхний регистр
                Console.Write("Input target currency (e.g. BYN, USD, EUR, RUB): ");
                targetCurrency = Console.ReadLine().ToUpper();
                Console.Write("Введите сколько кол-во валюты: ");
                amountInput = Console.ReadLine();

                string exchangeType = (sourceCurrency + "_в_" + targetCurrency); //Соединяет для исп Enum

                sellCheck = Enum.TryParse(exchangeType, out SellCourse);
                buyCheck = Enum.TryParse(exchangeType, out BuyCourse);
                amountCheck = double.TryParse(amountInput, out amount);

                bool inputCheck = (sellCheck && amountCheck) || (buyCheck && amountCheck); //Если введенные данные правильные
                if (!inputCheck)
                {
                    Console.Clear();
                    Console.WriteLine("Неправильное значение, попробуйте ещё раз!");
                }
            }
            while (!(sellCheck || buyCheck));

            if (sellCheck)
            {
                amountAfterExchange = amount * ((int)SellCourse / 10000.0);
            }
            else
            {
                amountAfterExchange = amount * (10000.0 / (int)BuyCourse);
            }
            Console.WriteLine($"{amountInput} {sourceCurrency} ровняется {amountAfterExchange:0.####} {targetCurrency}");

            Console.ReadKey();
        }
    }
}
