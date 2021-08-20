using System;
namespace listadeexercicios.Views

{
    public class Exercicio2
    {  
        public static void Renderizar()
        {
            double real, dolar, euro, peso;
            // dolar = 5,17;
            // euro = 6,14;
            // peso = 0,05
            Console.WriteLine("Informe o valor em Reais: ");
            real = Convert.ToDouble(Console.ReadLine());
            dolar = real / 5.25; 
            euro  = real / 6.14;
            peso = real / 0.05;
            Console.WriteLine($"Dolar: {dolar.ToString("F2")}  Euro: {euro.ToString("F2")}  Peso Argentino: {peso.ToString("F2")}");   

        }
    }
}