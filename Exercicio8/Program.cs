using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Posicao posicao = new Posicao();
            Console.WriteLine("Digite um numero");
            posicao.alterarPosicao(int.Parse(Console.ReadLine()));
        }
    }
}
