using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class Exc2
    {
        public void Exc02()
        {
            string nome, sexo, estadoCivil;
            int tempoCasada = 0;

            Console.Write("Digite o nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite o sexo (F/M): ");
            sexo = Console.ReadLine();

            Console.Write("Digite o estado civil: ");
            estadoCivil = Console.ReadLine();

            if (sexo.ToUpper() == "F" && estadoCivil.ToUpper() == "CASADA")
            {
                Console.Write("Digite o tempo de casada em anos: ");
                tempoCasada = Convert.ToInt32(Console.ReadLine());
            }

            // Aqui você pode utilizar os valores lidos conforme sua necessidade
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Sexo: " + sexo);
            Console.WriteLine("Estado Civil: " + estadoCivil);

            if (tempoCasada > 0)
            {
                Console.WriteLine("Tempo de casada: " + tempoCasada + " anos");
            }
        }
    }
}
