using System;
using System.Globalization;

namespace Calculadora {
    class Program {
        static void Main(string[] args) {
            var culture = CultureInfo.InvariantCulture;

            double primeiroNumero, segundoNumero;

            Console.Write("Digite o primeiro número: ");
            primeiroNumero = double.Parse(Console.ReadLine(), culture);
            Console.Write("Operação (+, -, *, /): ");
            string operacao = Console.ReadLine();
            if (operacao == "/") {
                do {
                    Console.Write("Digite o divisor (diferente de 0): ");
                    segundoNumero = double.Parse(Console.ReadLine(), culture);
                    if (segundoNumero == 0) {
                        Console.WriteLine("Não é permitido divisão por 0");
                    }
                } while (segundoNumero == 0);
            } else {
                Console.Write("Digite o segundo número: ");
                segundoNumero = double.Parse(Console.ReadLine(), culture);
            }           

            Calculadora calc = new Calculadora(primeiroNumero, segundoNumero, operacao);

            Console.WriteLine($"Resultado da operação: {calc.Escolha().ToString("F2", culture)}");

        }
    }
}