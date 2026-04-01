using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercicio8
{
     class Posicao
    {
        int numero;


        public void alterarPosicao(int numero)
        {
            
                exibirNumero(numero - 1);
                exibirNumero(numero);
                exibirNumero(numero + 1);
         

        }

        public void exibirNumero(int num)
        {
            Console.Write("Pos:{0} ",num);
        }
    }
}
