using System;
using System.Globalization;

namespace Calculadora {
    class Program {
        static void Main(string[] args) {
            var culture = CultureInfo.InvariantCulture;

            
            Console.Write("Digite o primeiro número: ");
            double primeiroNumero = double.Parse(Console.ReadLine(), culture);
            Console.Write("Digite o segundo número: ");
            double segundoNumero = double.Parse(Console.ReadLine(), culture);
            Console.Write("Operação: ");
            string operacao = Console.ReadLine();

            Calculadora calc = new Calculadora(primeiroNumero, segundoNumero, operacao);

            Console.WriteLine($"Resultado da operação: {calc.Escolha(operacao, primeiroNumero, segundoNumero)}");

        }
    }
}