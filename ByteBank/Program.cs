﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(4564, 789684);
                ContaCorrente conta2 = new ContaCorrente(7891, 456794);

                // conta1.Transferir(10000, conta2);
                conta1.Sacar(10000);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                // Console.WriteLine("Informações da INNER EXCEPTION (exceção interna):");

            }

            Console.WriteLine("Execução finalizada. Tecle enter para sair");
            Console.ReadLine();
        
        //try
        //{
        //    ContaCorrente conta = new ContaCorrente(456, 4578420);
        //    ContaCorrente conta2 = new ContaCorrente(486, 45784888);

        //    conta2.Transferir(10000, conta);

        //    conta.Depositar(50);
        //    Console.WriteLine(conta.Saldo);
        //    conta.Sacar(-500);
        //    Console.WriteLine(conta.Saldo);
        //}
        //catch (SaldoInsuficienteException ex)
        //{
        //    Console.WriteLine(ex.Saldo);
        //    Console.WriteLine(ex.ValorSaque);

        //    Console.WriteLine(ex.StackTrace);

        //    Console.WriteLine(ex.Message);
        //    Console.WriteLine("Exceção do tipo SaldoInsuficienteException");
        //}
        //catch (ArgumentException ex) {
        //    if(ex.ParamName == "numero")
        //    {

        //    }

        //    Console.WriteLine("Argumento com problema: " + ex.ParamName);
        //    Console.WriteLine("Ocorreu uma exceçao do tipo  AgumentException");
        //    Console.WriteLine(ex.Message);
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //Console.WriteLine(ContaCorrente.TaxaOperacao);
        Console.WriteLine("Execução finalizada. Tecle enter para sair");
            Console.ReadLine();
        }
    }
}
