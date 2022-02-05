using System;

namespace salarioConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite seu salario");
            Console.WriteLine("nos informe qual é o seu salario atual:");
            double salario1 = double.Parse(Console.ReadLine());
            double salario2 = salario1 * 1.15;
            double salario3 = salario2 * 0.92;

            Console.WriteLine($" O seu salario era de R${salario1:F2}, com o aumento ele foi para o R${salario2:F2} porem com os impostos ficou com o R${salario3:F2}");

            Console.ReadLine();
        }
    }
}
