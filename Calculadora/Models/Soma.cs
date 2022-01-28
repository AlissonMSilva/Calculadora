using System;

namespace Calculadora.Models
{
    public class Soma
    {
        public void Somar(float n1,float n2)
        {
            Console.Clear();
            Console.WriteLine($"{n1} + {n2} = {n1+n2} ");
            Console.ReadKey();
            var menu=new Menu();
            menu.Seletor();
        }
    }
    
}