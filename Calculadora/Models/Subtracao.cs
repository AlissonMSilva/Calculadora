using System;

namespace Calculadora.Models
{
    public class Subtracao
    {
        public void Subtrair(float n1, float n2)
        {
            Console.Clear();

            Console.WriteLine($"A subtracao dos valores e de: {n1 - n2}");
            Console.ReadKey();
            var menu = new Menu();
            menu.Seletor();
        }
    }
}