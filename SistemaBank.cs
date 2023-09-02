using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoRezende
{
    public class SistemaBank
    {
        public int NUMEROCONTA { get; private set; }
        public string NOME { get; set; }
        private double SALDO;


        public SistemaBank(string nome, int numerodaconta)
        {
            NOME = nome;
            NUMEROCONTA = numerodaconta;
            SALDO = 0;
        }

        public SistemaBank()
        {
            SALDO = 0;
        }

        public void Depositar(double valor)
        {
            SALDO += valor;
        }

        public void Sacar(double valor)
        {
            SALDO -= valor;
        }

        public double GetSaldo()
        {
            return SALDO;
        }
    }
}

