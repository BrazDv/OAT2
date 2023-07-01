using OAT2;
using System;

namespace Program.cs
{
    public class Menu
    {
        public static void Main()
        {
            int opcao;
            do
            {
                Console.WriteLine(" Exercicio (01) ");
                Console.WriteLine(" Exercicio (02) ");
                Console.WriteLine(" Exercicio (03) ");
                Console.WriteLine(" Exercicio (04) ");
                Console.WriteLine(" Exercicio (05) ");
                Console.WriteLine(" Exercicio (06) ");
                Console.WriteLine(" Exercicio (07) ");
                Console.WriteLine(" Exercicio (08) ");
                Console.WriteLine(" Exercicio (09) ");
                Console.WriteLine(" Exercicio (010) ");
                Console.WriteLine(" Exercicio (011) ");
                Console.WriteLine(" Exercicio (012) ");
                Console.WriteLine("(0) Sair");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Exc1 Objeto1 = new Exc1();
                       Objeto1.Exc01();
                        break;
                    case 2:
                        Exc2 Objeto2 = new Exc2();
                        Objeto2.Exc02();
                        break;
                    case 3:
                        Exc3 Objeto3 = new Exc3();
                        Objeto3.Exc03();
                        break;
                    case 4:
                        Exc4 Objeto4 = new Exc4();
                        Objeto4.Exc04();
                        break;
                    case 5:
                        Exc5 Objeto5 = new Exc5();
                        Objeto5.Exc05();
                        break;
                    case 6:
                        Exc6 Objeto6 = new Exc6();
                        Objeto6.Exc06();
                        break;
                    case 7:
                        Exc7 Objeto7 = new Exc7();
                        Objeto7.Exc07();
                        break;
                    case 8:
                        Exc8 Objeto8 = new Exc8();
                        Objeto8.Exc08();
                        break;
                    case 9:
                        Exc9 Objeto9 = new Exc9();
                        Objeto9.Exc09();
                        break;
                    case 10:
                        Exc10 Objeto10 = new Exc10();
                        Objeto10.Exc010();
                        break;
                    case 11:
                        Exc11 Objeto11 = new Exc11();
                        Objeto11.Exc011();
                        break;
                    case 12:
                        Exc12 Objeto12 = new Exc12();
                        Objeto12.Exc012();
                        break;
                }
            } while (opcao != 0);
        }
     }     
}

             