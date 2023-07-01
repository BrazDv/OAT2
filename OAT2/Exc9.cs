using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class Exc9
    {
        public void Exc09()
        {
            double altura, pesoIdeal;
            string sexo;

            Console.Write("Digite a altura em metros: ");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o sexo (M/F): ");
            sexo = Console.ReadLine();

            if (sexo.ToUpper() == "M")
            {
                pesoIdeal = (72.7 * altura) - 58;
            }
            else if (sexo.ToUpper() == "F")
            {
                pesoIdeal = (62.1 * altura) - 44.7;
            }
            else
            {
                Console.WriteLine("Sexo inválido.");
                return;
            }

            Console.WriteLine("O peso ideal é: " + pesoIdeal + " kg");
        }
    }
}
