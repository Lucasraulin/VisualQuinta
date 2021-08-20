using System;

namespace PrimeiroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primeiro App em C#");
            Console.WriteLine("Digite seu nome:");
            string name = Console.ReadLine();
            Console.WriteLine("Digite sua idade:");
            int age = Convert.ToInt32(Console.ReadLine());
         //   Console.WriteLine("Nome: " + name);
          //  Console.WriteLine("Sua idade é: " + age);
            Console.WriteLine($"Nome: {name} e idade: {age}");
        }
    }
}
