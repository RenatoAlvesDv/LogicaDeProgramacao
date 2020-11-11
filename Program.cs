using System;

namespace Logica_de_programacao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aqui vai o cosigo
           // Console.WriteLine("Digite o seu nome:");
           // string nomeCompleto = Console.ReadLine();


            //Console.WriteLine("Bem vindo "+nomeCompleto);
            
            int valorUm;
            int valorDois;

            Console.WriteLine("Soma de dois números");
            Console.WriteLine("--------------------");
            Console.WriteLine("Digite o primeiro valor");
            valorUm = int.Parse(Console.ReadLine());
            Console.Write ("Digite o segundo valor: ");
            valorDois = int.Parse(Console.ReadLine());
            
            //Processamento
            int soma = valorUm + valorDois;
            
            //Exbir

            Console.WriteLine("A Soma de "+valorUm+" + "+valorDois+" = "+soma);
            
        }
    }
}
 