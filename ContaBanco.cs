﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MeuSuperBanco
{
    public class ContaBanco
    {
        public string Numero { get; }
        public string Dono { get; set; }
        public decimal Saldo { 
            get 
            { 
                decimal saldo = 0;
                foreach (var item in allTransactions)
                {
                    saldo += item.Valor;
                }
                return saldo;
            } 
        }

        public static int numeroConta = 1234567890;

        private List<Transactions> allTransactions = new List<Transactions>();

        public ContaBanco(string nome, decimal valor) 
        { 
            this.Dono = nome;

            numeroConta++;

            this.Numero = numeroConta.ToString();
            Depositar(valor, DateTime.Now, "Saldo inicial");
        }

        public void Depositar( decimal valor, DateTime data, string obs)
        {
            Transactions transaction = new Transactions(valor, data, obs);
            allTransactions.Add(transaction);
        }
        public void Sacar(decimal valor, DateTime data, string obs)
        {
            Transactions transaction = new Transactions(-valor, data, obs);
            allTransactions.Add(transaction);
        }
    }
}
