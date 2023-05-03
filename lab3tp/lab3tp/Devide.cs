using System;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
    public class Divide
    {
        public void Run()
        {
            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Результат: {a / b}");
        }

    }
}