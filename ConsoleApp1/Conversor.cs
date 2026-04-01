using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio7
{
    class Conversor
    {
        double dolar, real;
        double total;

        public void solicitarDolar()
        {
            Console.WriteLine("Digite o valor da cotação do Dolar($)");
            dolar = double.Parse(Console.ReadLine());

        }
        public void solicitarReal()
        {
            Console.WriteLine("Digite o valor da cotação do Real(R$)");
            real = double.Parse(Console.ReadLine());

        }

        public void  converter() {
            total = dolar * real;
        }
        public void mostrar()
        {
            Console.WriteLine("Total em Reais R${0}",total);
        }
    }
}
