using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composicao.Entities.Enum;


namespace Composicao.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Dept { get; set; }
        public List<HourContract> Contract { get; set; } = new List<HourContract>();

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department dept)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Dept = dept;
            // Eliminado a lista do construtor. Será adicionado por método addContract 
        }

        public void addContract(HourContract contract)
        {
            Contract.Add(contract);
        }

        public void removeContract(HourContract contract)
        {
            Contract.Remove(contract);
        }

        public double income(int year, int month)
        {
            double x = BaseSalary;
            foreach(HourContract obj in Contract)
            {
                if(obj.Date.Year == year && obj.Date.Month == month)
                {
                    x +=obj.totalValue(); 
                }
            }
            return x;
        }

        public override string ToString()
        {
            return Name + ", " + Level + ", " + BaseSalary + ", " + Dept;

        }
    }
}
