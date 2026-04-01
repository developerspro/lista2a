using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA3003
{
     class Calculadora
    {
        public double total; 

        public void media(double n1,double n2,double n3)
        {
            total = (n1 + n2 + n3) / 3;
        }

       public void exibirTotal()
        {
            Console.WriteLine("total:{0}",total);
        }

        public void avaliar()
        {
            if (total >= 7) {
                Console.WriteLine("Aluno Aprovado!");
                exibirTotal();
            } else
            {
                Console.WriteLine("Aluno Reprovado!");
                exibirTotal();
            }
        }

        public double verificaNota(double nota)
        {

            while (nota < 0 || nota > 10)
            {
                Console.WriteLine("Nota inválida");
                nota = solicitarNota();
            }
            return nota;

        }
        public double solicitarNota()
        {
            double nota;
            Console.WriteLine("digite a nota");
            nota = double.Parse(Console.ReadLine());
            nota = verificaNota(nota);

            return nota;
        }
    }
}
