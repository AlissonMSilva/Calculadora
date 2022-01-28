using System;

namespace Calculadora.Models
{
    public class Porcentagem
    {
        public void Porcento()
        {
            Console.WriteLine("Valor que deseja saber: ");
            float v1=float.Parse(Console.ReadLine());
            Console.WriteLine("Porcentagem desejada: ");
            float p1=float.Parse(Console.ReadLine());

            Console.WriteLine($"{p1}% de {v1} = "+ v1 * ( p1 / 100));
        }
    }
}