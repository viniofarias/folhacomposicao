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
        public HourContract DataContract { get; set; }

        public Worker(string name, WorkerLevel level, double baseSalary, Department dept, HourContract dataContract)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Dept = dept;
            DataContract = dataContract;
        }

    }
}
