namespace PilaresPOO.Classes.Pilares
{
    public class ContaCorrente : Conta
    {
        public float limite { get; set; }


        public override float Sacar(float valor)
        {
            if (valor <= Saldo){
                Saldo = Saldo - valor;
                return valor;
            } else {
                return valor;
            }


        }
        public override bool Depositar(float valor)
        {
            if (valor > 0){
            Saldo = Saldo + valor;
            return true;
            } else {
                return false;
            }
        }

        public bool Transferir(float valor, Conta contaDestino)
        {
            return false;
        }

    }
}