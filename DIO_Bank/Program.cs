using System;
using System.Collections.Generic;

namespace DIO_Bank
{
    class Program
    {
        static List<Conta> listaContas = new List<Conta>();
        
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcao();

            while(opcaoUsuario.ToUpper()!= "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarContactos();
                        break;
                    case "2":
                        InserirConta();
                        break;
                    case "3":
                        Transferir();
                        break;
                    case "4":
                        Sacar();
                        break;
                    case "5":
                        Deposistar();
                        break;
                    case "C":
                        Limpar();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(); 

                }

                opcaoUsuario = ObterOpcao(); 
            }

            Console.WriteLine("Obrigado por Utilizar os nossos Servios");
            Console.ReadLine(); 


        }

        private static void ListarContactos()
        {
            Console.WriteLine("Listar Contas");
            if (listaContas.Count == 0)
            {
                Console.WriteLine("Nenhuma Conta Cadastrada. ");
                
            }

            for(int i= 0; i<listaContas.Count; i++)
            {
                Conta contaCliente = listaContas[i];
                Console.WriteLine("#{0} - {1}", i, contaCliente); 
            }
        }

        private static void InserirConta()
        {
            Console.WriteLine("Inserir contas\n");
           Console.ReadLine();

            Console.WriteLine("Digita 1 para Conta individual ou 2 para conta Empresa");
            int tipoConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digita o Saldo da conta");
            double saldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digita O credito da conta");
            double credito = double.Parse(Console.ReadLine());

            Console.WriteLine("Digita O Nome do Proprietario da conta");
            string nome = Console.ReadLine();



            Conta conta = new Conta((TipoContas)tipoConta, saldo, credito, nome);

            listaContas.Add(conta); 
        }

        private static void Transferir()
        {
            Console.WriteLine("Transferencia de valores");
            Console.ReadLine();

            Console.WriteLine("Digite o numero da conta da orgem  ");
            int indiceContaOrigem = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero da conta do beneficiario ");
            int indiceContaDestino = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Valor a ser Transferido ");
            double valorTransferencia = int.Parse(Console.ReadLine());

            listaContas[indiceContaOrigem].Transferir(valorTransferencia, listaContas[indiceContaDestino]); 
        }

        private static void Sacar()
        {
            Console.WriteLine("SACAR OS VALORE DA CONTA");
            Console.ReadLine();

            Console.WriteLine("Inserir  o numero da Conta ");
            int indiceContaSaque = int.Parse(Console.ReadLine());

            Console.WriteLine("Digita o valor que pretente levantar  ");
            double valorSaque = double.Parse(Console.ReadLine());

            listaContas[indiceContaSaque].Sacar(valorSaque); 

        }

        private static void Deposistar()
        {
            Console.WriteLine("Deposito de Valores");
            Console.ReadLine();

            Console.WriteLine("Inserir  o numero da Conta ");
            int indiceContaDeposito = int.Parse(Console.ReadLine());

            Console.WriteLine("Digita o valor que pretente levantar  ");
            double valorDeposito = double.Parse(Console.ReadLine());

            listaContas[indiceContaDeposito].Depositar(valorDeposito);
        }

        private static void Limpar()
        {
            Console.Clear(); 
        }


        private static string ObterOpcao()
        {
            Console.WriteLine();
            Console.WriteLine("DIO bank  a seu  dispor !!");
            Console.WriteLine("Informe a opção Desejada: ");
            Console.WriteLine("1 -  Listar contas");
            Console.WriteLine("2 - Inserir Nova Conta");
            Console.WriteLine("3 - Tranferencia");
            Console.WriteLine("4 - Sacar");
            Console.WriteLine("5 - Deposistar");
            Console.WriteLine("C - Limpar a Tela ");
            Console.WriteLine("X - Sair ");

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();

            return opcaoUsuario; 

        }
    }
}
