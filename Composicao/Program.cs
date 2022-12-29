using System;
using Composicao.Entities.Enum;
using Composicao.Entities;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace Composicao
{
    class FolhaDePgto
    {
        static void Main(string[] args)
        {
            WorkerLevel funcLevel = new WorkerLevel();
            string[] vecDate = new string[3];
            DateTime date = new DateTime();
            List<HourContract> contract = new List<HourContract>();


        Console.WriteLine("Digite o nome do departamento: ");
            string dep = (Console.ReadLine());
            Department dept = new Department(dep);

            Console.WriteLine("Digite os dados do Trabalhador: ");
            Console.Write("Nome: ");
            string name = Console.ReadLine();

            Console.Write("Digite o Level/Cargo (JUNIOR/MD_LEVEL/SENIOR): ");
            string level = Console.ReadLine();
            switch(level) 
            {
                case "JUNIOR":
                    funcLevel = Enum.Parse<WorkerLevel>("JUNIOR");
                    break;
                case "MD_LEVEL":
                    funcLevel = Enum.Parse<WorkerLevel>("MD_LEVEL");
                    break;
                case "SENIOR":
                    funcLevel = Enum.Parse<WorkerLevel>("SENIOR");
                    break;
            }

            Console.Write("Base Salarial: ");
            double salary = double.Parse(Console.ReadLine());

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

                contract.Add(new HourContract(date, valueHour, timer));
                //add lista de contratos e ter cuidado com variável que existe apenas dentro do laço
            }
            Worker x= new Worker(name, funcLevel, salary, dept, contract);
            //Console.Write("Digite o mês e o ano para calcular o rendimento do funcionário:  ");
            //
            //Console.Write("Nome: ");
            //name = Console.ReadLine();

            //Console.WriteLine("Departamento");
            //dep = (Console.ReadLine());
            //dept = new Department(dep);
            Console.WriteLine(x);
            foreach (HourContract obj in contract)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
