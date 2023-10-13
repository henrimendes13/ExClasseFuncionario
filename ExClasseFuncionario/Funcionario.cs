using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExClasseFuncionario
{
    class Funcionario
    {
        public string Nome;
        public double SalaraioBruto;
        public double Imposto;
        

        public double SalarioLiquido()
        {
            return SalaraioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalaraioBruto = SalaraioBruto + (SalaraioBruto * ((porcentagem)*0.01));
        }

        public override string ToString()
        {
            return Nome + ", " + "$" +SalarioLiquido().ToString("f2");
        }

        
    }
}
