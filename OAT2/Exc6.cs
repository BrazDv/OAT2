using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class Exc6
    {
        public void Exc06()
        {
            bool valor1, valor2;

            Console.Write("Digite o valor 1 (true/false): ");
            valor1 = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Digite o valor 2 (true/false): ");
            valor2 = Convert.ToBoolean(Console.ReadLine());

            if (valor1 && valor2)
            {
                Console.WriteLine("Ambos os valores são VERDADEIROS.");
            }
            else if (!valor1 && !valor2)
            {
                Console.WriteLine("Ambos os valores são FALSOS.");
            }
            else
            {
                Console.WriteLine("Um dos valores é VERDADEIRO e o outro é FALSO.");
            }
        }
    }
}
