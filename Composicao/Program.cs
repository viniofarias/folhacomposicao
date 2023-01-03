using System;
using Composicao.Entities.Enum;
using Composicao.Entities;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;

namespace Composicao
{
    class FolhaDePgto
    {
        static void Main(string[] args)
        {
            WorkerLevel funcLevel = new WorkerLevel();
            string[] vecDate = new string[3];
            string[] vecDateIncome = new string[2];
            DateTime date = new DateTime();
            //List<HourContract> contract = new List<HourContract>();


        Console.WriteLine("Digite o nome do departamento: ");
            string dep = (Console.ReadLine());
            Department dept = new Department(dep);

            Console.WriteLine("Digite os dados do Trabalhador: ");
            Console.Write("Nome: ");
            string name = Console.ReadLine();

            Console.Write("Digite o Level/Cargo (JUNIOR/MD_LEVEL/SENIOR): ");
            string level = Console.ReadLine();
            funcLevel = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base Salarial: ");
            double salary = double.Parse(Console.ReadLine());
            Worker x = new Worker(name, funcLevel, salary, dept); // construtor atualizado


            Console.WriteLine("Quantos Contratos para esse funcionário? ");
            int n = int.Parse(Console.ReadLine());
            for(int repeat = 0; repeat < n; repeat++)
            {
                Console.WriteLine("Digite os dados do Contrato{0}",repeat+1);
                Console.Write("Data (DD/MM/YYYY): ");
                vecDate = Console.ReadLine().Split('/');
                int day = int.Parse(vecDate[0]);
                int month = int.Parse(vecDate[1]);
                int year = int.Parse(vecDate[2]);
                date = new DateTime(year, month, day);

                Console.Write("Valor por hora: ");
                double valueHour = double.Parse(Console.ReadLine());

                Console.Write("Duração (horas): ");
                int timer = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valueHour, timer);
                x.addContract(contract);
                //add lista de contratos e ter cuidado com variável que existe apenas dentro do laço
            }
            Console.Write("Digite o mês e o ano para calcular o rendimento do funcionário:  ");
            vecDateIncome = Console.ReadLine().Split('/');
            int monthIncome = int.Parse(vecDateIncome[0]);
            int yearIncome = int.Parse(vecDateIncome[1]);

            double gain = x.income(yearIncome, monthIncome);
            Console.WriteLine("Nome: {0}",x.Name);
            Console.WriteLine("Departamento {0}",x.Dept.Name);
            Console.WriteLine("Level: {0}", x.Level);
            Console.WriteLine("Income for {0}/{1}: {2}", monthIncome, yearIncome, gain.ToString("F2", CultureInfo.InvariantCulture));

           
        }
    }
}
