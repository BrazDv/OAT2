using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT2
{
    public class Exc11
    {
        public void Exc011()
        {
            double precoEtiqueta, valorPago;
            int codigoPagamento;

            Console.Write("Digite o preço normal de etiqueta: ");
            precoEtiqueta = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escolha a condição de pagamento:");
            Console.WriteLine("1 - À vista em dinheiro ou cheque");
            Console.WriteLine("2 - À vista no cartão de crédito");
            Console.WriteLine("3 - Em duas vezes, sem juros");
            Console.WriteLine("4 - Em duas vezes, com juros de 10%");
            Console.Write("Digite o código da condição de pagamento: ");
            codigoPagamento = Convert.ToInt32(Console.ReadLine());

            switch (codigoPagamento)
            {
                case 1:
                    valorPago = precoEtiqueta * 0.9;
                    Console.WriteLine("Valor a ser pago: " + valorPago);
                    break;
                case 2:
                    valorPago = precoEtiqueta * 0.85;
                    Console.WriteLine("Valor a ser pago: " + valorPago);
                    break;
                case 3:
                    valorPago = precoEtiqueta;
                    Console.WriteLine("Valor a ser pago: " + valorPago);
                    break;
                case 4:
                    valorPago = precoEtiqueta * 1.1;
                    Console.WriteLine("Valor a ser pago: " + valorPago);
                    break;
                default:
                    Console.WriteLine("Código de pagamento inválido.");
                    break;
            }
        }
    }
}
