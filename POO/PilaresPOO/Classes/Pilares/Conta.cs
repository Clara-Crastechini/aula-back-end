using System.Reflection;

namespace PilaresPOO.Classes.Pilares
{
    public abstract class Conta
    {
        public string Titular;

        protected float Saldo { get; set; }

        public abstract float Sacar(float valor);

        public abstract bool Depositar(float valor);


        public float getSaldo(){
            return Saldo;
        }

    }
}