using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class Exc10
    {
        public void Exc010()
        {
            double peso, altura, imc;

            Console.Write("Digite o peso em kg: ");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura em metros: ");
            altura = Convert.ToDouble(Console.ReadLine());

            imc = peso / (altura * altura);

            Console.WriteLine("O IMC é: " + imc);

            if (imc < 18.5)
            {
                Console.WriteLine("Condição: Abaixo do peso");
            }
            else if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("Condição: Peso normal");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("Condição: Acima do peso");
            }
            else
            {
                Console.WriteLine("Condição: Obeso");
            }
        }

    }
}
