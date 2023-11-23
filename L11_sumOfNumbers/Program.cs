using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L11_sumOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int maxNumber = 101;
            int minNumber = 0;
            int multiply1 = 3;
            int multiply2 = 5;
            int sumOfNumber = 0;
            int randomNumber = random.Next(minNumber, maxNumber);

            for (int i = minNumber; i <= randomNumber; i++)
            {
                if ((i % multiply1) == 0 || (i % multiply2) == 0)
                    sumOfNumber += i;
            }

            Console.WriteLine($"Сумма всех чисел от {minNumber} до {randomNumber} включительно," +
                              $" кратных {multiply1} или {multiply2}, равна {sumOfNumber}");
        }
    }
}
