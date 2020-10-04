using System;

namespace heron
{
    class Program
    {
        static void Main(string[] args)
        {
            double lado1;
            double lado2;
            double lado3;
            double semiperimetro;
            double area; 

            Console.WriteLine("Digite os lados do triângulo desejado: \n");
            Console.Write("Lado 1: ");
            lado1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Lado 2: ");
            lado2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Lado 3: ");
            lado3 = Convert.ToDouble(Console.ReadLine());
            semiperimetro = (lado1 + lado2 + lado3) /2; 
            Console.WriteLine($"\nSemiperímetro {semiperimetro}");
            area = semiperimetro * (semiperimetro - lado1) * (semiperimetro - lado2) * (semiperimetro - lado3);
            Console.WriteLine($"Area {Math.Sqrt(area)}");
            
    



        }
    }
}
