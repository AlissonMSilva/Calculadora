using System;

namespace Calculadora.Models
{
    public class Multiplicacao
    {
        public void Multiplicar(float n1,float n2)
        {
            Console.Clear();
            Console.WriteLine($"{n1} x {n2} = {n1*n2}");
            Console.ReadKey();

            var menu=new Menu();
            menu.Seletor();
        }
    }
}