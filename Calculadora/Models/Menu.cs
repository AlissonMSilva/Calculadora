using System;

namespace Calculadora.Models
{
    public class Menu
    {
        public void Seletor()
        {
            float n1=0;
            float n2=0;
            Console.Clear();

            var opc = Opc();
            
            Calculos(opc);
        }

        public void Calculos(short opc)
        {
            if (opc < 5 && opc!=0)
            {
                Console.WriteLine("Primiero Valor: ");
                n1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Segundo Valor: ");
                n2 = float.Parse(Console.ReadLine());
            }

            switch (opc)
            {
                case 1:
                    var soma = new Soma();
                    soma.Somar(n1, n2);
                    break;
                case 2:
                    var sub = new Subtracao();
                    sub.Subtrair(n1, n2);
                    break;
                case 3:
                    var divi = new Divisao();
                    divi.Dividir(n1, n2);
                    break;
                case 4:
                    var mult = new Multiplicacao();
                    mult.Multiplicar(n1, n2);
                    break;
                case 5:
                    var porcent=new Porcentagem();
                    porcent.Porcento();
                    break;
                case 6:
                    var imc=new IMC();
                    imc.CalcuIMC();
                    break;
                case 0:
                    System.Environment.Exit(0);
                    break;
                default:
                    Seletor();
                    break;
            }
        }

        public int Opc()
        {
            Console.Clear();

            Console.WriteLine("Escolha uma das alternativas: ");

            Console.WriteLine("1 - Soma");

            Console.WriteLine("2 - Subtracao");

            Console.WriteLine("3 - Divisao");

            Console.WriteLine("4 - Multiplicacao");

            Console.WriteLine("5 - Porcentagem");

            Console.WriteLine("6 - IMC");

            Console.WriteLine("0 - Sair");

            Console.WriteLine("--------------------");
            short opc = short.Parse(Console.ReadLine());

            return opc;
        }
    }

}