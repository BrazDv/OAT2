using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class Exc1
    {
        public void Exc01()
        {
            int valorA, valorB, valorC;

            Console.Write("Digite o valor de A: ");
            valorA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            valorB = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            valorC = Convert.ToInt32(Console.ReadLine());

            if (valorA + valorB < valorC)
            {
                Console.WriteLine("A + B é menor que C");
            }
            else
            {
                Console.WriteLine("A + B não é menor que C");
            }
        }
    }
}
