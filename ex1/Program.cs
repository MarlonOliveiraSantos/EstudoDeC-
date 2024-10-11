using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {

            Conta mauricio = new Conta();
            mauricio.saldo = 2000.0;
            mauricio.idade = 18;
            Conta copia = new Conta();

            //mauricio.Transfere(2000,copia);
            mauricio.Saca(2000);




        }
    }

    public class Conta
    {
        public int numero;
        public string titular;
        public double saldo;
        public int idade;

        public void Detales()
        {
            Console.WriteLine(this.saldo);
        }

        public void Deposita(double valor)
        {
            this.saldo += valor;
        }

        public bool Saca(double valor)
        {
            if (this.idade < 18)
            {
                Console.WriteLine("Você é menor de idade. Só pode sacar 200,00");
                if(valor <= 200)
                {
                    this.saldo -= valor;
                    Console.WriteLine("Saque realizado com sucesso. Seu saldo atual é = " + this.saldo);
                      return true;
                } else 
                {
                    Console.WriteLine("Valor de saque excede o limite. Seu saldo atual é = " + this.saldo);
                    return false;
                }
            } else if (this.saldo >= valor)
            {
                this.saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso. Seu saldo atual é = " + this.saldo);
                return true;
            }
            else {
            Console.WriteLine("Seu saldo é insuficiente. Saldo atual = " + this.saldo);
            return false;
            }
        }

        public void Transfere(double valor, Conta destino)
        {
            if (this.Saca(valor))
            {
                destino.Deposita(valor);
                Console.WriteLine("Você acabou de transferir " + valor);
            }
        }
    }
}
