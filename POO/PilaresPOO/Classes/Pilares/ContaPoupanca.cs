namespace PilaresPOO.Classes.Pilares
{
    public class ContaPoupanca : Conta
    {
        public int limiteSaque { get; set; }

        public float Rendimento { get; set; }


        public override float Sacar(float valor)
        {
            // Saldo = Saldo - valor;

            return valor;
        }
        public override bool Depositar(float valor)
        {
            throw new NotImplementedException();
        }

        
        

    }
}