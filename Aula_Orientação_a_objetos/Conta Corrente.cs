using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Orientação_a_objetos
{
    internal class Conta_Corrente
    {
        public string Titular;
        public int Contatitular;
        public double Saldo;
        private double Saque;
        private double Deposito;


    public Conta_Corrente(string titular, int contatitular, double saldo)
        {
            Titular = titular;
            Contatitular = contatitular;
            Saldo = saldo;
        }

        public double Depositar(double deposito)
        {
            return Saldo + deposito ;
        }
        public string Sacar(double saque)
        {
            if(Saldo < saque) 
            {
                return "Não foi possível realizar o seu saque por falta se saldo";
            }
            Saldo = Saldo - saque;
            return $"O saque foi realizado com sucesso, o novo saldo é {Saldo}";
             
        }
         public double ExibeSaldo()
        {
            return Saldo ;
        }

        public string GetAccountDetails()
        {
            return $"Titular: {Titular} Conta: {Contatitular} Saldo: {Saldo}";
        }

    }
}
