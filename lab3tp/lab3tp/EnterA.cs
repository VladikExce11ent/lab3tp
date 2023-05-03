using System;
using System.Collections.Generic;
using System.Text;

namespace Menu
{
    public class EnterA
    {
        public void Run()
        {
            Console.WriteLine("Введите значение A:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Вы ввели: " + a);
        }
    }
}