using System;

namespace Calculadora.Models
{
    public class IMC
    {
        public void CalcuIMC()
        {
            Console.WriteLine("Digite seu peso atual: ");
            float peso =float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite sua altura: ");

            string altura= Console.ReadLine();
            if(!altura.Contains(',')) altura=altura.Insert(1,",");

            float valorAltura=float.Parse(altura);

            float imc=peso/(valorAltura*valorAltura);

            Console.Write($"Seu IMC: {imc.ToString("F")}/m²");
            Console.ReadLine();
            
            Console.WriteLine($"{NivelIMC(imc)}");

            Console.ReadKey();
            var menu=new Menu();
            menu.Seletor();
        }
        public string NivelIMC(float imc)
        {
            if(imc < 18.5)
            {
               return "Magreza";
            }
            else if(imc > 18.5 && imc <24.9)
            {
               return "Normal";
            }
            else if(imc > 25 && imc <29.9)
            {  
                return "Sobre Peso";
            }
            else if(imc > 30 && imc<39.9)
            {
                return "Obesidade";
            }
                return "Obesidade Grave";
        }
    }
}