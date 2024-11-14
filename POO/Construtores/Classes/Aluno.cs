namespace Construtores.Classes
{
    public class Aluno
    {
        public string nome { get; set; }

        public int CPF { get; set; }

        public Aluno(string nm, int cpf)
        {
            nome = nm;
            CPF = cpf;
        }

        public void ExibirDados()
        {
            Console.WriteLine(@$"
            nome: {nome}
            CPF: {CPF}");
        }
    }
}