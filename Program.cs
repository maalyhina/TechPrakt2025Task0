using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Обчислення суми двох чисел");
            Console.WriteLine("Перше число:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Друге число:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;

            Console.WriteLine("Сума чисел: " + sum);
        }
    }
}
