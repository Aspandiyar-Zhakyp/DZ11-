﻿using System;
using System.IO;

namespace EnumerationStructuresPractice
{
    class Program
    {


        static void Main(string[] args)
        {
            Employee[] employeers;
            Console.WriteLine("Введите размерность массива");
            int a = int.Parse(Console.ReadLine());
            int n = Convert.ToInt32(a);
            employeers = new Employee[n];
            for (int i = 0; i < n; i++)

            {
                employeers[n] = new Employee();
                Console.WriteLine("Введите имя");
                employeers[n].name = Console.ReadLine();

                Console.WriteLine("Введите зарплату");
                employeers[n].Salary = Console.ReadLine();
                Console.WriteLine("Введите вакансию");
                employeers[n].vacancy = Console.ReadLine();
                Console.WriteLine("Введите дату принятия на работу");
                employeers[n].DateOfStartWork = Console.ReadLine();
            }
        }

    }
}
