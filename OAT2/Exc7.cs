using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class Exc7
    {
        public void Exc07()
        {
            int numero;

            Console.Write("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                numero += 5;
            }
            else
            {
                numero += 8;
            }

            Console.WriteLine("O resultado da operação é: " + numero);
        }
    }
}
