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

        public double Somar() {
            double resultado = PrimeiroNumero + SegundoNumero;
            return resultado;
        }

        public double Subtracao() {
            double resultado = PrimeiroNumero - SegundoNumero;
            return resultado;
        }

        public double Multiplicacao() {
            double resultado = PrimeiroNumero * SegundoNumero;
            return resultado;
        }

        public double Divisao() {
            double resultado = PrimeiroNumero / SegundoNumero;
            return resultado;
        }

        public double Escolha() {
            switch (Operacao) {
                case "+":
                    return Somar();
                case "-":
                    return Subtracao();                    
                case "*":
                    return Multiplicacao();                    
                case "/":
                    return Divisao();                    
                default:
                    Console.WriteLine("Operação inválida!");                   
                    return double.NaN;
            }            
        }
    }
}
