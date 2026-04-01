using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio6
{
    internal class Dobro
    {
        double numero;
        double dobro;

        public void solicitarNumero()
        {
            Console.WriteLine("Digite um numero para calcular o Dobro");
            numero = double.Parse(Console.ReadLine());
        }

        public void calcularDobro()
        {
            dobro = numero * 2;
        }

        public void mostrarResultado()
        {
            Console.WriteLine("numero:{0} e seu dobro:{1}",numero,dobro);
        }
    }
}
