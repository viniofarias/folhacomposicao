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

        public Worker(string name, WorkerLevel level, double baseSalary, Department dept, List<HourContract> contract)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Dept = dept;
            Contract = contract;
        }
        public override string ToString()
        {
            return Name + ", " + Level + ", " + BaseSalary + ", " + Dept;

        }
    }
}
