namespace PilaresPOO.Classes.Aprendizagem
{
    public class Professor : Pessoa
    {
        public int NIF { get; set; }

        public float Salario { get; set; }

        public Professor(int _nif){
            NIF = _nif;
        }
    }
}