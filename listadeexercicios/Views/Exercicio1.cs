
using System;

namespace listadeexercicios.Views
{
    public class Exercicio1
    {   int largura, altura, area;
        public static void Renderizar()
        {
            int largura, altura, area;
            Console.WriteLine("Digite a Largura:");
            largura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a Altura:");
            altura = Convert.ToInt32(Console.ReadLine());
            area = altura * largura;
            Console.WriteLine($"Área: { area } ");
        }
    }
}