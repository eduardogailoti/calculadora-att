using System;
using System.Globalization;


namespace Calculadora {
    class Calculadora {
        public double PrimeiroNumero;
        public double SegundoNumero;
        public string Operacao;

        public Calculadora(double primeiroNumero, double segundoNumero, string operacao) {
            PrimeiroNumero = primeiroNumero;
            SegundoNumero = segundoNumero;
            Operacao = operacao;
        }

        public double Somar(double primeiro, double segundo) {
            double resultado = primeiro + segundo;
            return resultado;
        }

        public double Subtracao(double primeiro, double segundo) {
            double resultado = primeiro - segundo;
            return resultado;
        }

        public double Multiplicacao(double primeiro, double segundo) {
            double resultado = primeiro * segundo;
            return resultado;
        }

        public double Divisao(double primeiro, double segundo) {
            double resultado;

            while (segundo <= 0) {
                Console.Write("Divisão inválida, tente divisor acima de 0: ");
                segundo = double.Parse(Console.ReadLine());
            }

            resultado = primeiro / segundo;
            return resultado;
        }

        public double Escolha(string operacao, double primeiro, double segundo) {
            switch (operacao) {
                case "+":
                    return Somar(primeiro, segundo);                   
                case "-":
                    return Subtracao(primeiro, segundo);                    
                case "*":
                    return Multiplicacao(primeiro, segundo);                    
                case "/":
                    return Divisao(primeiro, segundo);                    
                default:
                    Console.WriteLine("Operação inválida!");                   
                    return double.NaN;
            }            
        }
    }
}
