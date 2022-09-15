using System;
namespace bytebank
{
    public class ContaCorrente
    {
        public string titular;
        public string conta;
        public int numero_agencia;
        public string nome_agencia;
        public double saldo;
        public bool verificador;
        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                return true;
            }

        }   
        public bool Depositar(double valor)
        {
            saldo = saldo + valor;
            if (valor > 0)
            {
                return true;
            }
            else return false;
        }

        public bool consultar(double saldo)
        {
            Console.WriteLine("O valor da conta da ana após o deposito de 5 reais é : " + saldo);
            return true;
        }
    }
}
