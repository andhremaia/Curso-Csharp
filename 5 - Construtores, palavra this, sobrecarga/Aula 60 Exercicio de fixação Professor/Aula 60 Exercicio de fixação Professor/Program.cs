﻿using System.Globalization;

namespace Aula_60_Exercicio_de_fixação_Professor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

             //ENTRADA DE DADOS
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine()!);
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine()!;
            Console.Write("Haverá depósito inicial (s/n)?");
            char resp = char.Parse(Console.ReadLine()!);

            if (resp == 's' ||  resp == 'S')
            {
                Console.Write("Entre o valor inicial: ");
                double DepositoInicial = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, DepositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            //DEPOSITO
            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            conta.Deposito(deposito);
            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            //SAQUE
            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            conta.Saque(saque);
            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
        }
    }
}