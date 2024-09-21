using System;

namespace DelegateOperacoes_AT
{
    class Program
    {
        public delegate int Operecao(int n1, int n2);

        public static int Somar (int n1, int n2)
        {
            int Soma = n1 + n2;
            Console.WriteLine($"{n1} + {n2} = {Soma}");
            return Soma;
        }

        public static int Subtracao(int n1, int n2)
        {
            int Subtracao = n1 - n2;
            Console.WriteLine($"{n1} - {n2} = {Subtracao}");
            return Subtracao;
        }

        public static int Multiplicacao(int n1, int n2)
        {
            int Multiplicar = n1 * n2;
            Console.WriteLine($"{n1} x {n2} = {Multiplicar}");
            return Multiplicar;
        }

        static int LerInteiro(string msg)
        {
            Console.Write(msg);
            return int.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 1 - AT");

            // declaração
            Operecao Soma = new Operecao(Somar);
            Operecao Subtrair = new Operecao(Subtracao);
            Operecao Multiplicar = new Operecao(Multiplicacao);

            int n1 = LerInteiro("Digite o 1° numero: ");
            int n2 = LerInteiro("Digite o 2° numero: ");

            Soma(n1, n2);
            Subtrair(n1, n2);
            Multiplicar(n1, n2);

            Console.ReadLine();

        }
    }
}