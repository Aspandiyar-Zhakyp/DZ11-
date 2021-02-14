using System;
using System.Collections.Generic;
using System.Text;

namespace EnumerationStructuresPractice
{
    struct Employee
    {
        public enum Vacancies
        {
            Manager, Boss, Clerk, Salesman
        }

        public string name;
        public int Salary;
        public int[] DateOfStartWork;
        public Vacancies vacancy;
    }
}
