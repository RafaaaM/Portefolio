using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod09_Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nome da empresa: Dino
            //5 empregados
            //Devolva o salario medio da empresa
            //Qual funcionario com maior salario

            double med; 
            double maior_salario;

            Class1 f1 = new Class1("Funcionario 1", 2500);
            Class1 f2 = new Class1("Funcionario 2", 3500);
            Class1 f3 = new Class1("Funcionario 3", 2000);
            Class1 f4 = new Class1("Funcionario 4", 2759);
            Class1 f5 = new Class1("Funcionario 5", 3012);

            List<int> salarios = new List<int> { };

            salarios.Add(f1.DevolveSalario());
            salarios.Add(f2.DevolveSalario());
            salarios.Add(f3.DevolveSalario());
            salarios.Add(f4.DevolveSalario());
            salarios.Add(f5.DevolveSalario());


            List<string> empregados = new List<string> { };

            empregados.Add(f1.DevolveEmpregado());
            empregados.Add(f2.DevolveEmpregado());
            empregados.Add(f3.DevolveEmpregado());
            empregados.Add(f4.DevolveEmpregado());
            empregados.Add(f5.DevolveEmpregado());

            med = salarios.Average();
            Console.WriteLine("O salário médio da empresa é: " + med);
            Console.WriteLine("O funcionário com maior salário é o "+empregados[salarios.IndexOf(salarios.Max())]+" com um salário de "+salarios.Max());
            

        }
    }
}
