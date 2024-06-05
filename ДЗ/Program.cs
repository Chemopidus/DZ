using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Виктор";
            int age = 32, programCount = 1, money = 999, time = 3;
            bool truth = true;

            Console.WriteLine("Здравствуйте, меня зовут " + name + ".");
            Console.WriteLine("Мне " + age + " года.");
            Console.WriteLine("Я хочу научиться делать игры, это моя " + programCount + "-ая программа на языке C#.");
            Console.WriteLine("Когда я закончу обучение, я хочу зарабатывать " + money + " денег в " + time + "наносекунд.");
            Console.WriteLine("Достигну ли я желаемого? " + truth + ".");
        }
    }
}
