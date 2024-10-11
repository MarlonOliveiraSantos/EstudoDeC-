using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta Marlon = new Conta();
            Conta Malaquias = new Conta();
            Marlon.saldo = 1000;
            Marlon.ShowDetails();
            Marlon.Transfere(500.0,Malaquias);
            Marlon.ShowDetails();
            Malaquias.ShowDetails();
            
        }
    }
    public class Conta
    {
        public int numero;
        public string titular;
        public double saldo;

        public bool Saca(double valor)
        {
            if (this.saldo >= valor)
            {
                this.saldo -= valor;
                return true;
            }
            return false;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Número da conta: {numero}");
            Console.WriteLine($"Titular: {titular}");
            Console.WriteLine($"Saldo: {saldo}");
        }

        public void Deposita(double valor)
        {
            this.saldo += valor;
        }

        public void Transfere(double valor, Conta destino)
        {
            if(this.Saca(valor))
            {             
                destino.Deposita(valor);
            }
        }
    }
}