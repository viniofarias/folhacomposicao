using System;
using Composicao.Entities.Enum;
using Composicao.Entities;
using System.Collections.Generic;

namespace Composicao
{
    class FolhaDePgto
    {
        static void Main(string[] args)
        {
            WorkerLevel funcLevel = new WorkerLevel();
            List<Worker> list = new List<Worker>();  

            string[] data = new string[3];
            Console.WriteLine("Digite o nome do departamento: ");
            string dep = Console.ReadLine();
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
            //
            Console.WriteLine("Quantos Contratos para esse funcionário? ");
            int n = int.Parse(Console.ReadLine());
            for(int repeat = 0; repeat < n; repeat++)
            {
                Console.WriteLine("Digite os dados do Contrato{0}",repeat+1);
                Console.Write("Data (DD/MM/YYYY): ");
                data = Console.ReadLine().Split('/');
                int day = int.Parse(data[0]);
                int month = int.Parse(data[1]);
                int year = int.Parse(data[2]);
                // construir datetime do worker
                Console.Write("Valor por hora: ");
                //
                Console.Write("Duração (horas): ");
                //
            }
            Console.Write("Digite o mês e o ano para calcular o rendimento do funcionário:  ");
            //
            Console.WriteLine("Nome: ");
        }
    }
}
