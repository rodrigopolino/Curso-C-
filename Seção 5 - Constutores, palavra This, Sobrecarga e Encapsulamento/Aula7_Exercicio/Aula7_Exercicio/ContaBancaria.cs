using System;
using System.Globalization;

namespace Aula7_Exercicio {
    internal class ContaBancaria {

        public int Numero { get; private set; } //número não pode ser alterado
        public string Titular { get; set; }
        public double Saldo { get; private set; } //só o usuário pode alterar, o programador não

        public ContaBancaria(int numero, string titular) {
            Numero = numero;
            Titular = titular;
            //Saldo = 0; //não precisa dessa linha
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this (numero, titular) {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia) { //double quantia = depositoInicial
            Saldo += quantia;
        }

        public void Saque(double quantia) {
            Saldo -= quantia + 5.0;
        }

        public override string ToString() {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
