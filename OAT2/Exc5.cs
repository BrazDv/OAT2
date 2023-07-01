using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class Exc5
    {
        public void Exc05()
        {
            int numero;

            Console.Write("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0)
            {
                int dobro = numero * 2;
                Console.WriteLine("O dobro do número é: " + dobro);
            }
            else if (numero < 0)
            {
                int triplo = numero * 3;
                Console.WriteLine("O triplo do número é: " + triplo);
            }
            else
            {
                Console.WriteLine("O número é zero, não possui dobro nem triplo.");
            }
        }
    }
}
