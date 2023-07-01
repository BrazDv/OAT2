using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class Exc4
    {
        public void Exc04()
        {
            int valorA, valorB, valorC;

            Console.Write("Digite o valor de A: ");
            valorA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            valorB = Convert.ToInt32(Console.ReadLine());

            if (valorA == valorB)
            {
                valorC = valorA + valorB;
            }
            else
            {
                valorC = valorA * valorB;
            }

            Console.WriteLine("O valor de C é: " + valorC);
        }
    }
}
