using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO_Bank
{
    class Conta
    {
        // os atributos da conta. 

        private TipoContas TipoContas { get; set; }
        private double Saldo { get; set; }
        private double Credidto { get; set; }
        private string  Nome { get; set; }

        //Construtor da class

        public Conta(TipoContas tipo, double saldo, double credito, string nome)
        {
            this.TipoContas = tipo;
            this.Saldo = saldo;
            this.Credidto = credito;
            this.Nome = nome; 
                
        }

        //Metodo de Saque

        public bool Sacar(double valorSaque)
        {
            //validar se ha condições de saque. 
            if(Saldo - valorSaque < 0)
            {
                Console.WriteLine("Saldo Insuficiente");
                return false; 
            }

            Saldo -= valorSaque;
            Console.WriteLine("O saldo actual da conta de " + Nome + " é de " + Saldo);

            return true; 
        }

        //Metodo de Deposito 
        public void Depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito;

            Console.WriteLine("O saldo actual da conta do " + Nome + " é de " + Saldo); 
        }

        //Metodo de Transferencia
        public void Transferir(double valorTransferencia, Conta contaDestino)
        {
            //Validação da transferencia.
            if (Sacar(valorTransferencia))
            {
                contaDestino.Depositar(valorTransferencia); 
            }
        }

        //saida das contas. 
        public override string ToString()
        {

            string retorno = "";
            retorno += "TipoContas " + this.TipoContas + " | ";
            retorno += "Nome " + this.Nome + " | ";
            retorno += "Credidto " + this.Credidto + " | ";
            retorno += "Saldo " + this.Saldo + " | ";

            return retorno;
        }
    }
}
