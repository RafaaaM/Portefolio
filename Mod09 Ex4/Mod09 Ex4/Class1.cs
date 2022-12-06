using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod09_Ex4
{
    internal class Class1
    {
        private string funcionarios;
        private int salario;


    public Class1(string funcionarios, int salario)
        {
            this.funcionarios = funcionarios;
            this.salario = salario;
        }
    public string DevolveEmpregado()
        {
            return funcionarios; 
        }

    public int DevolveSalario()
        {
            return salario;
        }
    }

}
