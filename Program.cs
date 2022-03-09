using System;

namespace peso_ideal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char s;
            double altura, resultado;
            Console.WriteLine("informe a sua altura!");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine("com letras minusculas utilize a primeira letra do seu sexo, m para masculino e f para feminino");
            s = char.Parse(Console.ReadLine());
            if(s == 'm')
            {
                Console.WriteLine("você é do sexo masculino");
                resultado = (72.7 * altura) - 58;
                Console.WriteLine("o seu peso ideal é {0}", resultado);
            }
            else 
            {
                Console.WriteLine("você é do sexo feminino");
                resultado = (61.2 * altura) - 44.7;
                Console.WriteLine("o seu peso ideal é {0}", resultado);
            }
        }
    }
}
