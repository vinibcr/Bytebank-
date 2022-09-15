using bytebank;
using System;
    

    
    class Program
    {
        
        static void Main(string[] args)
        {
        //comentar é crtl +k c ;
        //descomentar crtl +k u;


        Console.WriteLine("Sistema Bytebank!\n");
            
            ContaCorrente conta1 = new ContaCorrente();
            conta1.titular = "André Silva";
            conta1.conta = "10123-X";
            conta1.numero_agencia = 23;
            conta1.nome_agencia = "Agência Central";
            conta1.saldo = 100;

            //conta1.verificador
            ContaCorrente conta2 = new ContaCorrente();
            conta2.titular = "Ana";
            conta2.conta = "5255-X";
            conta2.numero_agencia = 43;
            conta2.nome_agencia = "agência BTG";
            conta2.saldo = 100;
            
            Titular Cliente = new Titular();
            Cliente.nome_cliente = "Pedro";
            Cliente.cpf_cliente = "42556699841";
            Cliente.titular_profissão = "Programador c#";

            Console.WriteLine("titular é :" + conta1.titular);
            Console.WriteLine("Conta é :" + conta1.conta);
            Console.WriteLine("numero_agencia : " + conta1.numero_agencia);
            Console.WriteLine("nome_agencia: " + conta1.nome_agencia);
            Console.WriteLine("Saldo total:" + conta1.saldo);
            //Console.WriteLine("verificação:" + conta1.verificador);
            Console.WriteLine("Saldo da ana pré saque : " + conta2.saldo);
            
            bool saque = conta2.Sacar(99);
            Console.WriteLine("Saldo da ana pós saque : " + conta2.saldo);
            //Console.WriteLine("Saldo da ana pós saque : " + saque);

            conta2.Depositar(5);
            //Console.WriteLine("Saldo da ana após o deposito: " + conta2.saldo);
            conta2.consultar(conta2.saldo);
            
            Console.ReadKey();
            
        }
    }

