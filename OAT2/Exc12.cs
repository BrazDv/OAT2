using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class Exc12
    {
        public void Exc012()
        {
            int numeroIdentificacao;
            double nota1, nota2, nota3, mediaExercicios, mediaAproveitamento;

            Console.Write("Digite o número de identificação do aluno: ");
            numeroIdentificacao = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a primeira nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a média dos exercícios: ");
            mediaExercicios = Convert.ToDouble(Console.ReadLine());

            mediaAproveitamento = (nota1 + nota2 * 2 + nota3 * 3 + mediaExercicios) / 7;

            Console.WriteLine("Número de identificação do aluno: " + numeroIdentificacao);
            Console.WriteLine("Notas: " + nota1 + ", " + nota2 + ", " + nota3);
            Console.WriteLine("Média dos exercícios: " + mediaExercicios);
            Console.WriteLine("Média de aproveitamento: " + mediaAproveitamento);

            if (mediaAproveitamento >= 90)
            {
                Console.WriteLine("Conceito: A");
                Console.WriteLine("Aprovado");
            }
            else if (mediaAproveitamento >= 75 && mediaAproveitamento < 90)
            {
                Console.WriteLine("Conceito: B");
                Console.WriteLine("Aprovado");
            }
            else if (mediaAproveitamento >= 60 && mediaAproveitamento < 75)
            {
                Console.WriteLine("Conceito: C");
                Console.WriteLine("Aprovado");
            }
            else if (mediaAproveitamento >= 40 && mediaAproveitamento < 60)
            {
                Console.WriteLine("Conceito: D");
                Console.WriteLine("Reprovado");
            }
            else
            {
                Console.WriteLine("Conceito: E");
                Console.WriteLine("Reprovado");
            }
        }
    }
}
