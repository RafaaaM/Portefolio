using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod9_ex_1
{
    public class Caixa
    {
        //caracteristicas ou atributos 

        double Lado;
        string cor;

        //construtor 

        public Caixa()
        {

        }

        //comportamento
        public double volume(double lado)
        {
            return lado * lado * lado;
        }

    }
}
