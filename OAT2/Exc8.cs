using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class Exc8
    {
        public void Exc08()
        {
            int valor1, valor2, valor3;

            Console.Write("Digite o primeiro valor inteiro: ");
            valor1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo valor inteiro: ");
            valor2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o terceiro valor inteiro: ");
            valor3 = Convert.ToInt32(Console.ReadLine());

            if (valor1 > valor2 && valor1 > valor3)
            {
                if (valor2 > valor3)
                {
                    Console.WriteLine("Ordem decrescente: " + valor1 + ", " + valor2 + ", " + valor3);
                }
                else
                {
                    Console.WriteLine("Ordem decrescente: " + valor1 + ", " + valor3 + ", " + valor2);
                }
            }
            else if (valor2 > valor1 && valor2 > valor3)
            {
                if (valor1 > valor3)
                {
                    Console.WriteLine("Ordem decrescente: " + valor2 + ", " + valor1 + ", " + valor3);
                }
                else
                {
                    Console.WriteLine("Ordem decrescente: " + valor2 + ", " + valor3 + ", " + valor1);
                }
            }
            else
            {
                if (valor1 > valor2)
                {
                    Console.WriteLine("Ordem decrescente: " + valor3 + ", " + valor1 + ", " + valor2);
                }
                else
                {
                    Console.WriteLine("Ordem decrescente: " + valor3 + ", " + valor2 + ", " + valor1);
                }
            }
        }
    }
}
